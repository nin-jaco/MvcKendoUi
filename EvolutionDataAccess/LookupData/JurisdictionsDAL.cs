using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionRepository.Models;

namespace EvolutionDataAccess.LookupData
{
    public class JurisdictionsDAL
    {
        public static List<Jurisdiction> GetOrganisationJurisdictionByUser(string UserName)
        {
            List<EvolutionRepository.Models.Jurisdiction> jurisdictions = new List<EvolutionRepository.Models.Jurisdiction>();

            return jurisdictions;
        }

        public static List<Jurisdiction> GetJurisdictions()
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                return ctx.Jurisdictions.AsNoTracking().ToList();
            }
        }

        public static List<Jurisdiction> GetJurisdictionByID(int JurisdictionID)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                return ctx.Jurisdictions.AsNoTracking().Where(x => x.JurisdictionID == JurisdictionID).ToList();
            }
        }

        public static List<Jurisdiction> GetJurisdictionByName(string JurisdictionName)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                return ctx.Jurisdictions.AsNoTracking().Where(x => x.JurisdictionName == JurisdictionName).ToList();
            }
        }

        public static List<Jurisdiction> GetJurisdictionByType(string JurisdictionType)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                return ctx.Jurisdictions.Where(x => x.JurisdictionTypesJurisdictionType.JurisdictionTypeName  == JurisdictionType).ToList();
            }
        }

        public static List<Jurisdiction> GetJurisdictionByParent(int JurisdictionParentID)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                return ctx.Jurisdictions.AsNoTracking().Where(x => x.JurisdictionParentID == JurisdictionParentID).ToList();
            }
        }

    }
}
