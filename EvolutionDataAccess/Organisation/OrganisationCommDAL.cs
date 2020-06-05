using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionDataAccess.Organisation
{
    public class OrganisationCommDAL
    {
        public static EvolutionRepository.ManualModels.GetOrganisationCommListResult GetAllOrganisationCommsByID(int organisationID, int skip, int take)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                int TotalInstancesWithoutSkipTake;

                ctx.Configuration.ProxyCreationEnabled = false;
                var orgComList = ctx.OrganisationComms.Where(p => p.OrganisationID == organisationID).ToList();

                if (orgComList != null)
                {
                    TotalInstancesWithoutSkipTake = orgComList.Count();
                    orgComList = orgComList.OrderBy(x => x.OrganisationCommID).Skip(skip).Take(take).ToList();
                    var orgComManualList = new List<EvolutionRepository.ManualModels.OrganisationCommSimple>();

                    foreach(var item in orgComList)
                    {
                        orgComManualList.Add(new EvolutionRepository.ManualModels.OrganisationCommSimple
                        {
                            Address = item.Address,
                            AddressPrefix = item.AddressPrefix,
                            OrganisationCommID = item.OrganisationCommID,
                            OrganisationCommTypeID = item.OrganisationCommTypeID,
                            OrganisationCommTypeName = ctx.OrganisationCommTypes.Where(p => p.OrganisationCommTypeID == item.OrganisationCommTypeID).FirstOrDefault().OrganisationCommTypeName,
                            OrganisationID = item.OrganisationID,
                            OrganisationName = ctx.Organisations.Where(p => p.OrganisationID == item.OrganisationID).FirstOrDefault().OrganisationName
                        });
                    }

                    return new EvolutionRepository.ManualModels.GetOrganisationCommListResult(orgComManualList.ToArray(), TotalInstancesWithoutSkipTake);
                }
                return null;
            }
        }

        public static EvolutionRepository.Models.OrganisationComm GetOrganisationCommByID(int organisationCommID)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                return ctx.OrganisationComms.AsNoTracking().FirstOrDefault(x => x.OrganisationCommID == organisationCommID);
            }
        }

        public static bool EditOrganisationComm(OrganisationComm updatedOrgCom)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_OrganisationComm_Update  @OrganisationID, @OrganisationCommTypeID, @Address, @AddressPrefix, @CommsHoneymoon, @OrganisationCommID",
                           new SqlParameter("@OrganisationID           ", updatedOrgCom.OrganisationID),
                           new SqlParameter("@OrganisationCommTypeID   ", updatedOrgCom.OrganisationCommTypeID),
                           new SqlParameter("@Address                  ", updatedOrgCom.Address),
                           new SqlParameter("@AddressPrefix            ", updatedOrgCom.AddressPrefix),
                           new SqlParameter("@CommsHoneymoon           ", updatedOrgCom.CommsHoneymoon),
                           new SqlParameter("@OrganisationCommID       ", updatedOrgCom.OrganisationCommID));
                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }

        public static bool InsertOrganisationComm(OrganisationComm newOrgCom)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_OrganisationComm_Insert  @OrganisationID, @OrganisationCommTypeID, @Address, @AddressPrefix, @CommsHoneymoon",
                           new SqlParameter("@OrganisationID           ", newOrgCom.OrganisationID),
                           new SqlParameter("@OrganisationCommTypeID   ", newOrgCom.OrganisationCommTypeID),
                           new SqlParameter("@Address                  ", newOrgCom.Address),
                           new SqlParameter("@AddressPrefix            ", newOrgCom.AddressPrefix),
                           new SqlParameter("@CommsHoneymoon           ", newOrgCom.CommsHoneymoon));

                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }

        public static bool DeleteOrganisationComm(int organisationCommID)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_OrganisationComm_Delete  @OrganisationCommID",
                           new SqlParameter("@OrganisationID           ", organisationCommID));

                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }
    }
}
