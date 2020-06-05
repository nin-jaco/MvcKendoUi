using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionDataAccess.LookupData;
using EvolutionRepository.ManualModels;
using EvolutionRepository.Models;

namespace EvolutionBusinessLogic.LookupData
{
    public class OrganisationTypes
    {
        public static List<EvolutionRepository.ManualModels.OrganisationTypeSimple> GetOrganisationType()
        {
            return EvolutionDataAccess.LookupData.OrganisationTypesDAL.GetOrganisationType();
        }

        public static List<EvolutionRepository.ManualModels.OrganisationTypeSimple> GetOrganisationSubType()
        {
            return EvolutionDataAccess.LookupData.OrganisationTypesDAL.GetOrganisationSubType();
        }

        public static List<EvolutionRepository.ManualModels.OrganisationTypeSimple> GetOrganisationSubTypeByTypeID(int OrganisationTypeID)
        {
            return EvolutionDataAccess.LookupData.OrganisationTypesDAL.GetOrganisationSubTypeByTypeID(OrganisationTypeID);
        }
    }
}