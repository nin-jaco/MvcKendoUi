using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class MachineConfig
    {
        public Nullable<long> SiteServerID { get; set; }
        public long MachineID { get; set; }
        public int SiteID { get; set; }
        public string MACAddress { get; set; }
        public int CertifiedModelID { get; set; }
        public Nullable<short> Position { get; set; }
        public short EnableCoinAcceptor { get; set; }
        public int CoinLockoutlevel { get; set; }
        public short EnableNoteAcceptor { get; set; }
        public int NoteLockoutlevel { get; set; }
        public bool EnableKeyIn { get; set; }
        public int MaximumKeyIn { get; set; }
        public bool EnableTicketIn { get; set; }
        public int MaximumTicketIn { get; set; }
        public bool EnableCashlessIn { get; set; }
        public int MaximumCashlessIn { get; set; }
        public bool EnableHopper1 { get; set; }
        public short Hopper1DenomID { get; set; }
        public short Hopper1LowLevelMark { get; set; }
        public short Hopper1HighLevelMark { get; set; }
        public short Hopper1DefaultRefillValue { get; set; }
        public bool EnableHopper2 { get; set; }
        public short Hopper2DenomID { get; set; }
        public short Hopper2LowLevelMark { get; set; }
        public short Hopper2HighLevelMark { get; set; }
        public short Hopper2DefaultRefillValue { get; set; }
        public bool EnableHopper3 { get; set; }
        public short Hopper3DenomID { get; set; }
        public short Hopper3LowLevelMark { get; set; }
        public short Hopper3HighLevelMark { get; set; }
        public short Hopper3DefaultRefillValue { get; set; }
        public short RandomNumberBufferSize { get; set; }
        public int CreditLimit { get; set; }
        public byte AutoplayAllowed { get; set; }
        public byte VLTBaseVolume { get; set; }
        public byte VLTGameVolume { get; set; }
        public byte AttractMode { get; set; }
        public byte AttractModeVolume { get; set; }
        public byte AdvertisingMode { get; set; }
        public byte AdvertisingModeVolume { get; set; }
        public byte HopperPayoutOrder { get; set; }
        public int HopperPayoutLimit { get; set; }
        public byte TicketOutOrder { get; set; }
        public int TicketOutLimit { get; set; }
        public byte CashlessOutOrder { get; set; }
        public int MaximumCashlessOut { get; set; }
        public Nullable<int> RTP { get; set; }
        public string IdentificationCode { get; set; }
        public Nullable<int> PTUCertifiedModelID { get; set; }
        public Nullable<int> AccountingDenomination { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public Nullable<int> DCTConfig { get; set; }
        public Nullable<int> DCTCommsProtocol { get; set; }
        public Nullable<int> DenomScaler { get; set; }
    }
}
