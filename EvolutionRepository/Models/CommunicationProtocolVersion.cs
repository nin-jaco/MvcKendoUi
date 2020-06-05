using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CommunicationProtocolVersion
    {
        public CommunicationProtocolVersion()
        {
            this.CommunicationProtocolVersionsCertifiedModels = new List<CertifiedModel>();
            this.CommunicationProtocolVersionsCommunicationProtocol = new List<CommunicationProtocol>();
        }

        public int ProtocolVersionID { get; set; }
        public string ProtocolVersionName { get; set; }
        public virtual ICollection<CertifiedModel> CommunicationProtocolVersionsCertifiedModels { get; set; }
        public virtual ICollection<CommunicationProtocol> CommunicationProtocolVersionsCommunicationProtocol { get; set; }
    }
}
