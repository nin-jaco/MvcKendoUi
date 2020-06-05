using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class ApprovedCertifiedModel
    {
        public int OrganisationID { get; set; }
        public int CertifiedModelID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string ApprovalNumber { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
