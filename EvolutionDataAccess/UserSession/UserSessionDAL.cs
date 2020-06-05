using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EvolutionRepository.ManualModels;

namespace EvolutionDataAccess.UserSession
{
    public class UserSessionDAL
    {
        public static void CreateUserSession(EvolutionRepository.ManualModels.UserSession userSession)
        {
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_UserSessionsCreate @SessionID, @UserName",
                    new SqlParameter("@SessionID", userSession.SessionID),
                    new SqlParameter("@UserName", userSession.UserName));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
