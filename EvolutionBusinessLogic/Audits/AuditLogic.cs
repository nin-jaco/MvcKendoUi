using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionRepository.Models;
using EvolutionDataAccess.Enumerations;

namespace EvolutionBusinessLogic.AuditLogic
{
    public class AuditLogic
    {
        public static bool AddAudit(Audit audit)
        {
            return EvolutionDataAccess.AuditDAL.CreateAudit(audit);
        }

        public static Audit GetAudit(int AuditID)
        {
            return EvolutionDataAccess.AuditDAL.GetAudit(AuditID);
        }

        public static List<Audit> GetAuditsByType (List<ActionType> actionTypes, BusinessUnits businessUnit)
        {
            return EvolutionDataAccess.AuditDAL.GetAuditsByType(actionTypes, businessUnit);
        }
    }
}