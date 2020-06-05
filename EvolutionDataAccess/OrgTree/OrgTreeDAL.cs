using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EvolutionDataAccess.OrgTree
{
    public class OrgTreeDAL
    {
        public static EvolutionRepository.ManualModels.GetOrgTreeListResult GetOrganisationsInTree(int TopOrganisationID)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;

                var Result = new EvolutionRepository.ManualModels.GetOrgTreeListResult();

                var OrgTreeList = ctx.OrgTrees.Where(p => p.TopOrganisationID == TopOrganisationID).OrderBy(x => x.OrganisationName).ToList();

                if (OrgTreeList != null)
                {
                    Result.Count = ctx.OrgTrees.Where(p => p.TopOrganisationID == TopOrganisationID).Count();
                    var orgTreeManualList = new List<EvolutionRepository.ManualModels.OrgTree>();
                    foreach (var item in OrgTreeList)
                    {
                        orgTreeManualList.Add(new EvolutionRepository.ManualModels.OrgTree
                        {
                            OrganisationID = item.OrganisationID,
                            OrganisationName = item.OrganisationName
                        });
                    }
                    Result.Data = orgTreeManualList;

                    return Result;
                }
                return null;
            }
        }

        public static List<EvolutionRepository.Models.OrgTree> GetOrgTree(string sessionID)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                var userSession = ctx.UserSessions.Where(p => p.SessionID == sessionID).First();

                var result = ctx.OrgTrees.Where(p => p.TopOrganisationID == userSession.TopOrganisationID).OrderBy(p => p.OrganisationName).ToList();

                return result;
            }
        }
    }
}
