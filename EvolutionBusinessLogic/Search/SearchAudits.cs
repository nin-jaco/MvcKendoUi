//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.Objects;

//namespace EvolutionBusinessLogic.Search
//{
//    public class SearchAudits
//    {

//       /// <summary>
//       /// Perform the Search used by the Maintenance screen.
//       /// </summary>
//       public static List<EvolutionRepository.Models.AuditEngagementApproval> GetAllAuditsForEngagementApprovals(Guid EngagementInstanceKey)
//       {

//           using (EvolutionRepository.Models.EvolutionDBContext ctx = new EvolutionRepository.Models.EvolutionDBContext())
//           {
//               return ctx.AuditEngagementApprovals.Where(x => x.EngagementInstanceKey == EngagementInstanceKey).OrderBy(x => x.DateOfChange).ToList();
//           }

//       }


//       /// <summary>
//       /// Perform the Search used by the Maintenance screen.
//       /// </summary>
//       public static List<EvolutionRepository.Models.AuditEngagementAttributeValueChange> GetAllAuditsForEngagementAttributeValueChanges(Guid EngagementInstanceKey)
//       {

//           using (EvolutionRepository.Models.EvolutionDBContext ctx = new EvolutionRepository.Models.EvolutionDBContext())
//           {
//               return ctx.AuditEngagementAttributeValueChanges.Where(x => x.EngagementInstanceKey == EngagementInstanceKey).OrderBy(x => x.DateOfChange).ToList();
//           }

//       }


//       /// <summary>
//       /// Perform the Search used by the Maintenance screen.
//       /// </summary>
//       public static List<EvolutionRepository.Models.AuditEngagementStateChange> GetAllAuditsForEngagementStateChanges(Guid EngagementInstanceKey)
//       {

//           using (EvolutionRepository.Models.EvolutionDBContext ctx = new EvolutionRepository.Models.EvolutionDBContext())
//           {
//               return ctx.AuditEngagementStateChanges.Where(x => x.EngagementInstanceKey == EngagementInstanceKey).OrderBy(x => x.DateOfChange).ToList();
//           }

//       }


//       /// <summary>
//       /// Perform the Search used by the Maintenance screen.
//       /// </summary>
//       public static EvolutionRepository.Models.AuditEngagementApproval GetAuditEngagementApproval(Int64 AuditEngagementApprovalID)
//       {

//           using (EvolutionRepository.Models.EvolutionDBContext ctx = new EvolutionRepository.Models.EvolutionDBContext())
//           {
//               return ctx.AuditEngagementApprovals.Where(x => x.AuditEngagementApprovalID == AuditEngagementApprovalID).FirstOrDefault();
//           }

//       }


//       /// <summary>
//       /// Perform the Search used by the Maintenance screen.
//       /// </summary>
//       public static EvolutionRepository.Models.AuditEngagementAttributeValueChange GetAuditEngagementAttributeValueChange(Int64 AuditEngagementAttributeValueChangeID)
//       {

//           using (EvolutionRepository.Models.EvolutionDBContext ctx = new EvolutionRepository.Models.EvolutionDBContext())
//           {
//               return ctx.AuditEngagementAttributeValueChanges.Where(x => x.AuditEngagementAttributeValueChangeID == AuditEngagementAttributeValueChangeID).FirstOrDefault();
//           }

//       }


//       /// <summary>
//       /// Perform the Search used by the Maintenance screen.
//       /// </summary>
//       public static EvolutionRepository.Models.AuditEngagementStateChange GetAuditEngagementStateChange(Int64 AuditEngagementStateChangeID)
//       {

//           using (EvolutionRepository.Models.EvolutionDBContext ctx = new EvolutionRepository.Models.EvolutionDBContext())
//           {
//               return ctx.AuditEngagementStateChanges.Where(x => x.AuditEngagementStateChangeID == AuditEngagementStateChangeID).FirstOrDefault();
//           }

//       }

//    }
//}
