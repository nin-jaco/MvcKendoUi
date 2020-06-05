using EvolutionDataAccess.Organisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.Organisations
{
    public class SplitLogic
    {
        public static EvolutionRepository.ManualModels.GetSplitListResult GetAllOrganisationSplits(int organisationID, int skip, int take)
        {
            return SplitDAL.GetAllOrganisationSplits(organisationID, skip, take);
        }


        public static bool SaveRevenueProfileSplits(EvolutionRepository.ManualModels.RevenueProfileSimple simpleProfile)
        {
            return SplitDAL.SaveRevenueProfileSplits(simpleProfile);
        }

    }
}
