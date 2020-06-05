using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Machine
    {
        public long MachineID { get; set; }
        public string SerialNumber { get; set; }
        public int OwnerID { get; set; }
        public int ManagedByID { get; set; }
        public int CertifiedModelID { get; set; }
        public int SiteID { get; set; }
        public Nullable<int> LifeCycleStatusId { get; set; }
        public Nullable<bool> IsCommandEnabled { get; set; }
        public Nullable<int> EnableOrganisationID { get; set; }
        public Nullable<int> CoinAcceptorCertifiedModelID { get; set; }
        public Nullable<int> CoinAcceptorID { get; set; }
        public Nullable<int> NoteAcceptorCertifiedModelID { get; set; }
        public Nullable<int> NoteAcceptorID { get; set; }
        public Nullable<int> Hopper1CertifiedModelID { get; set; }
        public Nullable<int> HopperID1 { get; set; }
        public Nullable<int> Hopper2CertifiedModelID { get; set; }
        public Nullable<int> HopperID2 { get; set; }
        public Nullable<int> Hopper3CertifiedModelID { get; set; }
        public Nullable<int> HopperID3 { get; set; }
        public string MACAddress { get; set; }
        public string IdentificationCode { get; set; }
        public Nullable<int> RTP { get; set; }
    }
}
