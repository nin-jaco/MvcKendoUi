using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CommunicationProtocol
    {
        public CommunicationProtocol()
        {
            this.CommunicationProtocolCertifiedModels = new List<CertifiedModel>();
        }

        public int ProtocolID { get; set; }
        public string ProtocolName { get; set; }
        public int ProtocolVersionID { get; set; }
        public virtual ICollection<CertifiedModel> CommunicationProtocolCertifiedModels { get; set; }
        public virtual CommunicationProtocolVersion CommunicationProtocolVersionsCommunicationProtocolVersion { get; set; }
    }
}
