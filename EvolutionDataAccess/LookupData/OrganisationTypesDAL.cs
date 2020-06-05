using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionRepository.ManualModels;
using EvolutionRepository.Models;

namespace EvolutionDataAccess.LookupData
{
    public class OrganisationTypesDAL
    {
        public static List<OrganisationTypeSimple> GetOrganisationType()
        {
            List<OrganisationTypeSimple> organisationTypesSimple = new List<OrganisationTypeSimple>();

            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                List<OrganisationType> organisationTypes = ctx.OrganisationTypes.AsNoTracking().OrderBy(x => x.OrganisationTypeName).ToList();

                foreach (var organisationType in organisationTypes)
                {
                    OrganisationTypeSimple organisationTypeSimple = new OrganisationTypeSimple();

                    organisationTypeSimple.OrganisationTypeID = organisationType.OrganisationTypeID;
                    organisationTypeSimple.OrganisationTypeName = organisationType.OrganisationTypeName;

                    organisationTypesSimple.Add(organisationTypeSimple);
                }
            }

            return organisationTypesSimple;
        }

        public static List<OrganisationTypeSimple> GetOrganisationSubType()
        {
            List<OrganisationTypeSimple> organisationTypesSimple = new List<OrganisationTypeSimple>();

            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                List<OrganisationSubType> organisationSubTypes = ctx.OrganisationSubTypes.AsNoTracking().OrderBy(x => x.OrganisationSubTypeName).ToList();

                foreach (var organisationSubType in organisationSubTypes)
                {
                    OrganisationTypeSimple organisationTypeSimple = new OrganisationTypeSimple();

                    organisationTypeSimple.OrganisationTypeID = organisationSubType.OrganisationSubTypeID;
                    organisationTypeSimple.OrganisationTypeName = organisationSubType.OrganisationSubTypeName;

                    organisationTypesSimple.Add(organisationTypeSimple);
                }
            }

            return organisationTypesSimple;
        }

        public static List<OrganisationTypeSimple> GetOrganisationSubTypeByTypeID(int OrganisationTypeID)
        {
            List<OrganisationTypeSimple> organisationTypesSimple = new List<OrganisationTypeSimple>();

            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                List<OrganisationSubType> organisationSubTypes = ctx.OrganisationSubTypes.AsNoTracking().Where(x => x.OrganisationTypeID == OrganisationTypeID).OrderBy(x => x.OrganisationSubTypeName).ToList();

                foreach (var organisationSubType in organisationSubTypes)
                {
                    OrganisationTypeSimple organisationTypeSimple = new OrganisationTypeSimple();

                    organisationTypeSimple.OrganisationTypeID = organisationSubType.OrganisationSubTypeID;
                    organisationTypeSimple.OrganisationTypeName = organisationSubType.OrganisationSubTypeName;

                    organisationTypesSimple.Add(organisationTypeSimple);
                }
            }

            return organisationTypesSimple;
        }
    }
}
