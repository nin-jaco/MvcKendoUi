using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionRepository.Models;
using EvolutionRepository.ManualModels;

namespace EvolutionBusinessLogic.OrgTree
{
    public class OrgTreeLogic
    {
        //public static List<EvolutionRepository.ManualModels.OrgTree> GetOrganisationsInTree(int TopOrganisationID)
        //{
        //    return EvolutionDataAccess.OrgTree.OrgTreeDAL.GetOrganisationsInTree(TopOrganisationID);
        //}
        //public static EvolutionRepository.ManualModels.GetOrgTreeListResult GetOrganisationsInTree(int TopOrganisationID)
        //{
        //    try
        //    {
        //        return EvolutionDataAccess.OrgTree.OrgTreeDAL.GetOrganisationsInTree(TopOrganisationID);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public static List<EvolutionRepository.Models.OrgTree> GetOrgTree(string sessionID)
        {
            try
            {
                return EvolutionDataAccess.OrgTree.OrgTreeDAL.GetOrgTree(sessionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
