using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EvolutionDataAccess.Organisation
{
    public class SplitDAL
    {
        public static EvolutionRepository.ManualModels.GetSplitListResult GetAllOrganisationSplits(int organisationID, int skip, int take)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                int TotalInstancesWithoutSkipTake;

                ctx.Configuration.ProxyCreationEnabled = false;
                var splitList = ctx.RevenueProfiles.Where(p => p.OrganisationID == organisationID && p.IsSplit == 1).ToList();

                if (splitList != null)
                {
                    TotalInstancesWithoutSkipTake = splitList.Count();
                    splitList = splitList.OrderBy(x => x.RevenueProfileID).Skip(skip).Take(take).ToList();
                    var splitManualList = new List<EvolutionRepository.ManualModels.RevenueProfileSimple>();

                    foreach (var item in splitList)
                    {
                        splitManualList.Add(new EvolutionRepository.ManualModels.RevenueProfileSimple
                        {
                            DateAdded = item.DateAdded,
                            RevenueProfileID = item.RevenueProfileID,
                            RevenueProfileName = item.RevenueProfileName,
                            RevenueProfileTypeID = item.RevenueProfileTypeID.Value,
                            RevenueProfileTypeName = ctx.RevenueProfileTypes.Where(p => p.RevenueProfileTypeID == item.RevenueProfileTypeID).FirstOrDefault().RevenueProfileTypeName,
                            DeductionTypeID = item.DeductionTypeID.Value,
                            DeductionTypeName = ctx.DeductionTypes.Where(p => p.DeductionTypeID == item.DeductionTypeID.Value).FirstOrDefault().DeductionTypeName,
                            DeductionTotalTypeID = item.DeductionTotalTypeID.Value,
                            DeductionTotalTypeName = ctx.DeductionTotalTypes.Where(p => p.DeductionTotalTypeID == item.DeductionTotalTypeID.Value).FirstOrDefault().DeductionTotalTypeName,
                            AppliesOrganisationTypeID = item.AppliesOrganisationTypeID.Value,
                            AppliesOrganisationTypeName = ctx.OrganisationTypes.Where(p => p.OrganisationTypeID == item.AppliesOrganisationTypeID.Value).FirstOrDefault().OrganisationTypeName,
                            CollectOrganisationTypeID = item.CollectOrganisationTypeID.Value,
                            CollectOrganisationTypeName = ctx.OrganisationTypes.Where(p => p.OrganisationTypeID == item.CollectOrganisationTypeID.Value).FirstOrDefault().OrganisationTypeName,
                            CreditOrganisationTypeID = item.CreditOrganisationTypeID.Value, 
                            CreditOrganisationTypeName = ctx.OrganisationTypes.Where(p => p.OrganisationTypeID == item.CreditOrganisationTypeID.Value).FirstOrDefault().OrganisationTypeName,
                            SiteSplit = 100 - ctx.RevenueScales.Where(s=>s.RevenueProfileID == item.RevenueProfileID && s.RevenueScaleID ==0).FirstOrDefault().Rate,
                            OperatorSplit = ctx.RevenueScales.Where(s=>s.RevenueProfileID == item.RevenueProfileID && s.RevenueScaleID ==0).FirstOrDefault().Rate
                        });
                    }

                    return new EvolutionRepository.ManualModels.GetSplitListResult(splitManualList.ToArray(), TotalInstancesWithoutSkipTake);
                }
                return null;
            }
        }


        public static bool SaveRevenueProfileSplits(EvolutionRepository.ManualModels.RevenueProfileSimple simpleProfile)
        {
            bool Result = false;
            try
            {
                //simpleProfile.SiteSplit
                //simpleProfile.OperatorSplit
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_SaveRevenueProfileSplits @RevenueProfileID,@RevenueProfileName,@OrganisationID,@DeductionTotalTypeID,@AppliesOrganisationTypeID," +
                        "@CollectOrganisationTypeID,@RevenueProfileTypeID,@DeductionTypeID,@CreditOrganisationTypeID,@IsSplit,@SiteSplit,@OperatorSplit",
                        new SqlParameter("@RevenueProfileID", simpleProfile.RevenueProfileID),
                        new SqlParameter("@RevenueProfileName", simpleProfile.RevenueProfileName),
                        new SqlParameter("@OrganisationID", simpleProfile.OrganisationID),
                        new SqlParameter("@DeductionTotalTypeID", simpleProfile.DeductionTotalTypeID),
                        new SqlParameter("@AppliesOrganisationTypeID", simpleProfile.AppliesOrganisationTypeID),
                        new SqlParameter("@CollectOrganisationTypeID", simpleProfile.CollectOrganisationTypeID),
                        new SqlParameter("@RevenueProfileTypeID", simpleProfile.RevenueProfileTypeID),
                        new SqlParameter("@DeductionTypeID", simpleProfile.DeductionTypeID),
                        new SqlParameter("@CreditOrganisationTypeID", simpleProfile.CreditOrganisationTypeID),
                        new SqlParameter("@IsSplit", true),
                        new SqlParameter("@SiteSplit",simpleProfile.SiteSplit),
                        new SqlParameter("@OperatorSplit", simpleProfile.OperatorSplit));
                }
                Result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Result;
        }





    }
}
