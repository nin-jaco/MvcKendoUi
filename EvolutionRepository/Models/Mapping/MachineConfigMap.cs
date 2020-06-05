using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MachineConfigMap : EntityTypeConfiguration<MachineConfig>
    {
        public MachineConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.MachineID);

            // Properties
            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MACAddress)
                .HasMaxLength(50);

            this.Property(t => t.IdentificationCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MachineConfig");
            this.Property(t => t.SiteServerID).HasColumnName("SiteServerID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.MACAddress).HasColumnName("MACAddress");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.EnableCoinAcceptor).HasColumnName("EnableCoinAcceptor");
            this.Property(t => t.CoinLockoutlevel).HasColumnName("CoinLockoutlevel");
            this.Property(t => t.EnableNoteAcceptor).HasColumnName("EnableNoteAcceptor");
            this.Property(t => t.NoteLockoutlevel).HasColumnName("NoteLockoutlevel");
            this.Property(t => t.EnableKeyIn).HasColumnName("EnableKeyIn");
            this.Property(t => t.MaximumKeyIn).HasColumnName("MaximumKeyIn");
            this.Property(t => t.EnableTicketIn).HasColumnName("EnableTicketIn");
            this.Property(t => t.MaximumTicketIn).HasColumnName("MaximumTicketIn");
            this.Property(t => t.EnableCashlessIn).HasColumnName("EnableCashlessIn");
            this.Property(t => t.MaximumCashlessIn).HasColumnName("MaximumCashlessIn");
            this.Property(t => t.EnableHopper1).HasColumnName("EnableHopper1");
            this.Property(t => t.Hopper1DenomID).HasColumnName("Hopper1DenomID");
            this.Property(t => t.Hopper1LowLevelMark).HasColumnName("Hopper1LowLevelMark");
            this.Property(t => t.Hopper1HighLevelMark).HasColumnName("Hopper1HighLevelMark");
            this.Property(t => t.Hopper1DefaultRefillValue).HasColumnName("Hopper1DefaultRefillValue");
            this.Property(t => t.EnableHopper2).HasColumnName("EnableHopper2");
            this.Property(t => t.Hopper2DenomID).HasColumnName("Hopper2DenomID");
            this.Property(t => t.Hopper2LowLevelMark).HasColumnName("Hopper2LowLevelMark");
            this.Property(t => t.Hopper2HighLevelMark).HasColumnName("Hopper2HighLevelMark");
            this.Property(t => t.Hopper2DefaultRefillValue).HasColumnName("Hopper2DefaultRefillValue");
            this.Property(t => t.EnableHopper3).HasColumnName("EnableHopper3");
            this.Property(t => t.Hopper3DenomID).HasColumnName("Hopper3DenomID");
            this.Property(t => t.Hopper3LowLevelMark).HasColumnName("Hopper3LowLevelMark");
            this.Property(t => t.Hopper3HighLevelMark).HasColumnName("Hopper3HighLevelMark");
            this.Property(t => t.Hopper3DefaultRefillValue).HasColumnName("Hopper3DefaultRefillValue");
            this.Property(t => t.RandomNumberBufferSize).HasColumnName("RandomNumberBufferSize");
            this.Property(t => t.CreditLimit).HasColumnName("CreditLimit");
            this.Property(t => t.AutoplayAllowed).HasColumnName("AutoplayAllowed");
            this.Property(t => t.VLTBaseVolume).HasColumnName("VLTBaseVolume");
            this.Property(t => t.VLTGameVolume).HasColumnName("VLTGameVolume");
            this.Property(t => t.AttractMode).HasColumnName("AttractMode");
            this.Property(t => t.AttractModeVolume).HasColumnName("AttractModeVolume");
            this.Property(t => t.AdvertisingMode).HasColumnName("AdvertisingMode");
            this.Property(t => t.AdvertisingModeVolume).HasColumnName("AdvertisingModeVolume");
            this.Property(t => t.HopperPayoutOrder).HasColumnName("HopperPayoutOrder");
            this.Property(t => t.HopperPayoutLimit).HasColumnName("HopperPayoutLimit");
            this.Property(t => t.TicketOutOrder).HasColumnName("TicketOutOrder");
            this.Property(t => t.TicketOutLimit).HasColumnName("TicketOutLimit");
            this.Property(t => t.CashlessOutOrder).HasColumnName("CashlessOutOrder");
            this.Property(t => t.MaximumCashlessOut).HasColumnName("MaximumCashlessOut");
            this.Property(t => t.RTP).HasColumnName("RTP");
            this.Property(t => t.IdentificationCode).HasColumnName("IdentificationCode");
            this.Property(t => t.PTUCertifiedModelID).HasColumnName("PTUCertifiedModelID");
            this.Property(t => t.AccountingDenomination).HasColumnName("AccountingDenomination");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.DCTConfig).HasColumnName("DCTConfig");
            this.Property(t => t.DCTCommsProtocol).HasColumnName("DCTCommsProtocol");
            this.Property(t => t.DenomScaler).HasColumnName("DenomScaler");
        }
    }
}
