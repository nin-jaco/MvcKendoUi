using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MachineMap : EntityTypeConfiguration<Machine>
    {
        public MachineMap()
        {
            // Primary Key
            this.HasKey(t => t.MachineID);

            // Properties
            this.Property(t => t.SerialNumber)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.MACAddress)
                .HasMaxLength(50);

            this.Property(t => t.IdentificationCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Machines");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
            this.Property(t => t.OwnerID).HasColumnName("OwnerID");
            this.Property(t => t.ManagedByID).HasColumnName("ManagedByID");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.LifeCycleStatusId).HasColumnName("LifeCycleStatusId");
            this.Property(t => t.IsCommandEnabled).HasColumnName("IsCommandEnabled");
            this.Property(t => t.EnableOrganisationID).HasColumnName("EnableOrganisationID");
            this.Property(t => t.CoinAcceptorCertifiedModelID).HasColumnName("CoinAcceptorCertifiedModelID");
            this.Property(t => t.CoinAcceptorID).HasColumnName("CoinAcceptorID");
            this.Property(t => t.NoteAcceptorCertifiedModelID).HasColumnName("NoteAcceptorCertifiedModelID");
            this.Property(t => t.NoteAcceptorID).HasColumnName("NoteAcceptorID");
            this.Property(t => t.Hopper1CertifiedModelID).HasColumnName("Hopper1CertifiedModelID");
            this.Property(t => t.HopperID1).HasColumnName("HopperID1");
            this.Property(t => t.Hopper2CertifiedModelID).HasColumnName("Hopper2CertifiedModelID");
            this.Property(t => t.HopperID2).HasColumnName("HopperID2");
            this.Property(t => t.Hopper3CertifiedModelID).HasColumnName("Hopper3CertifiedModelID");
            this.Property(t => t.HopperID3).HasColumnName("HopperID3");
            this.Property(t => t.MACAddress).HasColumnName("MACAddress");
            this.Property(t => t.IdentificationCode).HasColumnName("IdentificationCode");
            this.Property(t => t.RTP).HasColumnName("RTP");
        }
    }
}
