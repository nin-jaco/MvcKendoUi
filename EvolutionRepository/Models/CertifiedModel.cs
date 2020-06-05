using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class CertifiedModel
    {
        public CertifiedModel()
        {
            this.CertifiedModelsCertifiedFiles = new List<CertifiedFile>();
            this.CertifiedModelsCertifiedGames = new List<CertifiedGame>();
            this.CertifiedModelCabinetsCabinets = new List<Cabinet>();
        }

        public int CertifiedModelID { get; set; }
        public int MachineTypeID { get; set; }
        public string CertifiedModelName { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public Nullable<int> GameThemeID { get; set; }
        public Nullable<int> DefaultPlayerDenom { get; set; }
        public Nullable<int> DefaultAccountingDenom { get; set; }
        public Nullable<int> MaximumBet { get; set; }
        public string SoftwareVersion { get; set; }
        public Nullable<int> ProtocolID { get; set; }
        public int ProtocolVersionID { get; set; }
        public string LOCNumber { get; set; }
        public Nullable<int> TLHashAlgorithmID { get; set; }
        public string TLHashResult { get; set; }
        public Nullable<System.DateTime> DateIssued { get; set; }
        public Nullable<int> LOCIssuedByID { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> ReviewDate { get; set; }
        public Nullable<bool> CashlessSupported { get; set; }
        public Nullable<bool> TicketingSupported { get; set; }
        public Nullable<int> FundsTransferMethodID { get; set; }
        public Nullable<int> CertifiedSoftwareHashingAlgorithmID { get; set; }
        public virtual ICollection<CertifiedFile> CertifiedModelsCertifiedFiles { get; set; }
        public virtual ICollection<CertifiedGame> CertifiedModelsCertifiedGames { get; set; }
        public virtual CertifiedSoftwareHashingAlgorithm CertifiedSoftwareHashingAlgorithmsCertifiedSoftwareHashingAlgorithm { get; set; }
        public virtual CertifiedSoftwareHashingAlgorithm CertifiedSoftwareHashingAlgorithms1CertifiedSoftwareHashingAlgorithm { get; set; }
        public virtual CommunicationProtocol CommunicationProtocol { get; set; }
        public virtual CommunicationProtocolVersion CommunicationProtocolVersionsCommunicationProtocolVersion { get; set; }
        public virtual FundsTransferMethod FundsTransferMethodsFundsTransferMethod { get; set; }
        public virtual GameTheme GameThemesGameTheme { get; set; }
        public virtual MachineType MachineTypesMachineType { get; set; }
        public virtual ICollection<Cabinet> CertifiedModelCabinetsCabinets { get; set; }
    }
}
