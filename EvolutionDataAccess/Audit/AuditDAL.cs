using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionRepository.Models;
using EvolutionDataAccess.Enumerations;
using System.Data.SqlClient;

namespace EvolutionDataAccess
{
    public class AuditDAL
    {
        public static bool CreateAudit(Audit audit)
        {
            bool result = false;
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    ctx.Database.ExecuteSqlCommand("Evo_Audits_Insert  @AuditType, @AuditDate, @OldValue, @NewValue, @IPAddress, @UserAgentString, @ChangeByUserID, @ChangeByFullName", 

                       new SqlParameter("@AuditType", audit.AuditType),
                       new SqlParameter("@AuditDate", audit.AuditDate),
                       new SqlParameter("@OldValue", audit.OldValue),
                       new SqlParameter("@NewValue", audit.NewValue),
                       new SqlParameter("@IPAddress", audit.IPAddress),
                       new SqlParameter("@UserAgentString", audit.UserAgentString),
                       new SqlParameter("@ChangeByUserID", audit.ChangeByUserID),
                       new SqlParameter("@ChangeByFullName", audit.ChangeByFullName)
                    );
                }
                result = true;
            }
            catch (Exception ex) {
                throw;
            }
            return result;
        }


        public static Audit GetAudit(int AuditID)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                return ctx.Audits.FirstOrDefault(x => x.AuditID == AuditID);
            }
        }

        public static List<Audit> GetAuditsByType(List<ActionType> actionTypes, BusinessUnits businessUnit)
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                return ctx.Audits.ToList();
            }
        }
    }
}
