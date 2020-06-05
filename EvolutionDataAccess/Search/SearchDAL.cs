using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionRepository.ManualModels;
using EvolutionRepository.Models;

namespace EvolutionDataAccess.Search
{
    public class SearchDAL
    {
        public static List<EvolutionRepository.ManualModels.OrganisationGrid> GetOrganisations(EvolutionRepository.ManualModels.SearchOrganisationsParams searchParams, EvolutionRepository.Models.User LoggedInUser, out int TotalInstancesWithoutSkipTake)
        {
            List<EvolutionRepository.ManualModels.OrganisationGrid> organisations = new List<EvolutionRepository.ManualModels.OrganisationGrid>();

            using (EvolutionRepository.Models.EvolutionDBContext ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                try
                {
                    //Get records from stored procedure with Skip ad Take applied
                    organisations = ctx.Database.SqlQuery<EvolutionRepository.ManualModels.OrganisationGrid>(
                        "exec uspGetOrganisation @parentorganisation, @organisation, @childto, @type, @subtype, @jurisdiction, @skip, @take",
                        new SqlParameter("@parentorganisation", Convert.ToInt32(searchParams.parentorganisation)),
                        new SqlParameter("@organisation", searchParams.organisation),
                        new SqlParameter("@childto", Convert.ToInt32(searchParams.childto)),
                        new SqlParameter("@type", Convert.ToInt32(searchParams.type)),
                        new SqlParameter("@subtype", Convert.ToInt32(searchParams.subtype)),
                        new SqlParameter("@jurisdiction", Convert.ToInt32(searchParams.jurisdiction)),
                        new SqlParameter("@skip", searchParams.skip),
                        new SqlParameter("@take", searchParams.take))
                        .ToList<EvolutionRepository.ManualModels.OrganisationGrid>();

                    //Get record count from stored procedure without Skip ad Take applied
                    string organisationsCount = ctx.Database.SqlQuery<string>(
                        "exec uspGetOrganisationCount @parentorganisation, @organisation, @childto, @type, @subtype, @jurisdiction",
                        new SqlParameter("@parentorganisation", Convert.ToInt32(searchParams.parentorganisation)),
                        new SqlParameter("@organisation", searchParams.organisation),
                        new SqlParameter("@childto", Convert.ToInt32(searchParams.childto)),
                        new SqlParameter("@type", Convert.ToInt32(searchParams.type)),
                        new SqlParameter("@subtype", Convert.ToInt32(searchParams.subtype)),
                        new SqlParameter("@jurisdiction", Convert.ToInt32(searchParams.jurisdiction))).ToString();

                    TotalInstancesWithoutSkipTake = 1; //Convert.ToInt32(organisationsCount);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            //return organisations.OrderBy(x => x.DateAdded).Skip(searchParams.skip).Take(searchParams.take).ToList();
            return organisations;
        }

    }
}