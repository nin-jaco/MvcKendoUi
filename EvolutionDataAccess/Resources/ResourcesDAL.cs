using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionRepository.ManualModels;
using EvolutionRepository.Models;

namespace EvolutionDataAccess.Resources
{
    public class ResourcesDAL
    {
        public static List<EvolutionRepository.ManualModels.Resource> GetResources(string sessionID, Boolean isNew)
        {
            List<EvolutionRepository.ManualModels.Resource> employeeResources = new List<EvolutionRepository.ManualModels.Resource>();

            using (EvolutionRepository.Models.EvolutionDBContext ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                try
                {
                    //Get records from stored procedure 
                    employeeResources = ctx.Database.SqlQuery<EvolutionRepository.ManualModels.Resource>(
                        "EXEC Evo_ResourcesForSession @SessionID, @IsNew",
                        new SqlParameter("@SessionID", sessionID),
                        new SqlParameter("@IsNew", isNew))
                        .ToList<EvolutionRepository.ManualModels.Resource>();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return employeeResources;
        }

    }
}