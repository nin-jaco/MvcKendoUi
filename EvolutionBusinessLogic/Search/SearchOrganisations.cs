using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionDataAccess.Search;

namespace EvolutionBusinessLogic.Search
{
    public class SearchOrganisations
    {
        private static int TotalInstancesWithoutSkipTake = 0;

        public static EvolutionRepository.ManualModels.SearchResult SearchForOrganisations(EvolutionRepository.ManualModels.SearchOrganisationsParams searchParams, EvolutionRepository.Models.User LoggedInUser)
        {
            var organisationsFound = new List<EvolutionRepository.ManualModels.OrganisationGrid>();

            try
            {
                //Call DAL and return organisation that the user is allowesd to within the search params
                var FoundOrganisations = EvolutionDataAccess.Search.SearchDAL.GetOrganisations(searchParams, LoggedInUser, out TotalInstancesWithoutSkipTake);

                foreach (var foundOrganisation in FoundOrganisations)
                {
                    var newOrganisation = new EvolutionRepository.ManualModels.OrganisationGrid()
                    {
                        OrganisationID = foundOrganisation.OrganisationID,
                        OrganisationName = foundOrganisation.OrganisationName,
                        DateAdded = foundOrganisation.DateAdded,
                        DateDeleted = foundOrganisation.DateDeleted,
                    };

                    if (foundOrganisation.CompanyNumber != null)
                    {
                        newOrganisation.CompanyNumber = foundOrganisation.CompanyNumber;
                    }
                    if (foundOrganisation.TelephoneNo != null)
                    {
                        newOrganisation.TelephoneNo = foundOrganisation.TelephoneNo;
                    }
                    if (foundOrganisation.ContactName != null)
                    {
                        newOrganisation.ContactName = foundOrganisation.ContactName;
                    }
                    if (foundOrganisation.WebSiteURL != null)
                    {
                        newOrganisation.WebSiteURL = foundOrganisation.WebSiteURL;
                    }
                    if (foundOrganisation.OrganisationStatusName != null)
                    {
                        newOrganisation.OrganisationStatusName = foundOrganisation.OrganisationStatusName;
                    }

                    organisationsFound.Add(newOrganisation);
                }
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Database error", "Evolution could not process the required stored procedure succesully. " + ex.Message);
            }

            return new EvolutionRepository.ManualModels.SearchResult(organisationsFound.ToArray(), TotalInstancesWithoutSkipTake);
        }

    }
}
