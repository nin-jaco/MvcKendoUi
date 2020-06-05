using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionDataAccess.Organisation
{
    public class AreaDAL
    {
        public static EvolutionRepository.ManualModels.GetAreaListResult GetAllAreasForOrganisation(int organisationID, int skip, int take)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                int TotalInstancesWithoutSkipTake;

                ctx.Configuration.ProxyCreationEnabled = false;
                var areas = ctx.Areas.Where(p => p.OrganisationID == organisationID).ToList();

                if (areas != null)
                {
                    TotalInstancesWithoutSkipTake = areas.Count;
                    areas = areas.OrderBy(x => x.AreaID).Skip(skip).Take(take).ToList();
                    var manualAreas = new List<EvolutionRepository.ManualModels.AreaSimple>();

                    foreach (var item in areas)
                    {
                        var manager = ctx.Employees.Where(p => p.EmployeeID == item.EmployeeID).FirstOrDefault();
                        manualAreas.Add(new EvolutionRepository.ManualModels.AreaSimple
                        {
                            AreaID = item.AreaID,
                            AreaName = item.AreaName,
                            EmergencyNumber = item.EmergencyNumber,
                            EmployeeFullname = manager.FirstName + " " + manager.LastName,
                            EmployeeID = item.EmployeeID.Value,
                            Mobile = item.Mobile,
                            OrganisationID = item.OrganisationID,
                            OrganisationName = ctx.Organisations.Where(p => p.OrganisationID == item.OrganisationID).FirstOrDefault().OrganisationName
                        });
                    }

                    return new EvolutionRepository.ManualModels.GetAreaListResult(manualAreas.ToArray(), TotalInstancesWithoutSkipTake);
                }
                return null;
            }
        }

        public static List<EvolutionRepository.Models.Employee> GetManagersForAnOrganisation(int organisationID)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                return ctx.Employees.AsNoTracking().Where(p => p.OrganisationID == organisationID).ToList();
            }
        }

        public static EvolutionRepository.Models.Area GetAreaByID(int areaID)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                return ctx.Areas.AsNoTracking().Where(p => p.AreaID == areaID).FirstOrDefault();
            }
        }

        public static bool UpdateArea(EvolutionRepository.Models.Area updatedArea)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_Areas_Update  @AreaID, @OrganisationID, @AreaName, @Telephone, @EmergencyNumber, @Mobile, @EmployeeID, @Total_staff_Allocted, @Total_Engineers_Allocated, @Total_Vehicles_Allocated",
                    new SqlParameter("@AreaID           ", updatedArea.AreaID),
                    new SqlParameter("@OrganisationID           ", updatedArea.OrganisationID),
                    new SqlParameter("@AreaName                 ", updatedArea.AreaName),
                    new SqlParameter("@Telephone                ", updatedArea.Telephone),
                    new SqlParameter("@EmergencyNumber          ", updatedArea.EmergencyNumber),
                    new SqlParameter("@Mobile                   ", updatedArea.Mobile),
                    new SqlParameter("@EmployeeID               ", updatedArea.EmployeeID),
                    new SqlParameter("@Total_staff_Allocted     ", null),
                    new SqlParameter("@Total_Engineers_Allocated", null),
                    new SqlParameter("@Total_Vehicles_Allocated ", null));

                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }

        public static bool AddArea(EvolutionRepository.Models.Area newArea)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {

                    ctx.Database.ExecuteSqlCommand("Evo_Areas_Insert  @OrganisationID, @AreaName, @Telephone, @EmergencyNumber, @Mobile, @EmployeeID, @Total_staff_Allocted, @Total_Engineers_Allocated, @Total_Vehicles_Allocated",
                    new SqlParameter("@OrganisationID           ", newArea.OrganisationID),
                    new SqlParameter("@AreaName                 ", newArea.AreaName),
                    new SqlParameter("@Telephone                ", newArea.Telephone),
                    new SqlParameter("@EmergencyNumber          ", newArea.EmergencyNumber),
                    new SqlParameter("@Mobile                   ", newArea.Mobile),
                    new SqlParameter("@EmployeeID               ", newArea.EmployeeID),
                    new SqlParameter("@Total_staff_Allocted     ", null),
                    new SqlParameter("@Total_Engineers_Allocated", null),
                    new SqlParameter("@Total_Vehicles_Allocated ", null));
                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }


        public static bool DeleteArea(int areaID) //EvolutionRepository.Models.Area AddArea)
        {
            var Result = false;

            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_Areas_Delete  @AreaID",
                    new SqlParameter("@AreaID           ", areaID));
                    Result = true;
                }
            }
            catch (Exception)
            {
                Result = false;
            }

            return Result;
        }

    }
}
