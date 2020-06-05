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
    public class Jurisdictions
    {
        public static List<EvolutionRepository.Models.Jurisdiction> GetOrganisationJurisdictionByUser(string sessionID, string UserName)
        {
            return EvolutionDataAccess.LookupData.JurisdictionsDAL.GetOrganisationJurisdictionByUser(UserName);
        }

        public static List<EvolutionRepository.Models.Jurisdiction> GetJurisdictions()
        {
            return EvolutionDataAccess.LookupData.JurisdictionsDAL.GetJurisdictions();
        }

        public static List<EvolutionRepository.Models.Jurisdiction> GetJurisdictionByID(int JurisdictionID)
        {
            return EvolutionDataAccess.LookupData.JurisdictionsDAL.GetJurisdictionByID(JurisdictionID);
        }

        public static List<EvolutionRepository.Models.Jurisdiction> GetJurisdictionByName(string JurisdictionName)
        {
            return EvolutionDataAccess.LookupData.JurisdictionsDAL.GetJurisdictionByName(JurisdictionName);
        }

        public static List<EvolutionRepository.Models.Jurisdiction> GetJurisdictionByType(string JurisdictionType)
        {
            return EvolutionDataAccess.LookupData.JurisdictionsDAL.GetJurisdictionByType(JurisdictionType);
        }

        public static List<EvolutionRepository.Models.Jurisdiction> GetJurisdictionByParent(int JurisdictionParentID)
        {
            return EvolutionDataAccess.LookupData.JurisdictionsDAL.GetJurisdictionByParent(JurisdictionParentID);
        }

    }
}