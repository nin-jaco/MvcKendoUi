using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.Resources
{
    public class Resources
    {
        public static string BuildMenu(string sessionID)
        {
            StringBuilder employeeMenu = new StringBuilder();
            List<EvolutionRepository.ManualModels.Resource> employeeResources = new List<EvolutionRepository.ManualModels.Resource>();
            try
            {
                employeeResources = EvolutionDataAccess.Resources.ResourcesDAL.GetResources(sessionID, false);
                // Build HTML for those resources with a defined Controller/Action
                foreach (EvolutionRepository.ManualModels.Resource resource in employeeResources)
                {
                    if (!String.IsNullOrEmpty(resource.Controller) && !String.IsNullOrEmpty(resource.Action))
                    {
                        employeeMenu.Append(@"<li class='divider'></li><li><a href='/");
                        employeeMenu.Append(resource.Controller);
                        employeeMenu.Append(@"/");
                        employeeMenu.Append(resource.Action);
                        //employeeMenu.Append(@"?sessionID=");
                        //employeeMenu.Append(sessionID);
                        employeeMenu.Append(@"'><span class='active'>");
                        employeeMenu.Append(resource.DisplayName);
                        employeeMenu.Append(@"</span></a></li>");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employeeMenu.ToString();
        }

        public static string BuildOrganisationMenu(string sessionID, string organisationID)
        {
            StringBuilder organisationMenu = new StringBuilder();
            List<EvolutionRepository.ManualModels.Resource> employeeResources = new List<EvolutionRepository.ManualModels.Resource>();

            try
            {
                employeeResources = EvolutionDataAccess.Resources.ResourcesDAL.GetResources(sessionID, false);

                // Build HTML for those resources with a defined Controller/Action
                foreach (EvolutionRepository.ManualModels.Resource resource in employeeResources)
                {
                    if (!String.IsNullOrEmpty(resource.Controller) && !String.IsNullOrEmpty(resource.Action))
                    {
                        organisationMenu.Append(@"<li class='divider'></li><li><a href='/");
                        organisationMenu.Append(resource.Controller);
                        organisationMenu.Append(@"/");
                        organisationMenu.Append(resource.Action);
                        organisationMenu.Append(@"'><span class='active'>");
                        organisationMenu.Append(resource.DisplayName);
                        organisationMenu.Append(@"</span></a></li>");
                        //<li class="@EvolutionWeb.Code.GlobalUtilities.IsActive("Administration/Groups", CurrentAction)">@Html.ActionLink("Addresses", "OrganisationsAddresses/"+OrganisationID)</li>
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return organisationMenu.ToString();
        }
    }
}
