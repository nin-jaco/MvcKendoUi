using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CertifiedModelMap : EntityTypeConfiguration<CertifiedModel>
    {
        public CertifiedModelMap()
        {
            // Primary Key
            this.HasKey(t => t.CertifiedModelID);

            // Properties
            this.Property(t => t.CertifiedModelName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SoftwareVersion)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LOCNumber)
                .HasMaxLength(50);

            this.Property(t => t.TLHashResult)
                .HasMaxLength(255);

            this.Property(t => t.Comments)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("CertifiedModels");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");
            this.Property(t => t.MachineTypeID).HasColumnName("MachineTypeID");
            this.Property(t => t.CertifiedModelName).HasColumnName("CertifiedModelName");
            this.Property(t => t.ManufacturerID).HasColumnName("ManufacturerID");
            this.Property(t => t.GameThemeID).HasColumnName("GameThemeID");
            this.Property(t => t.DefaultPlayerDenom).HasColumnName("DefaultPlayerDenom");
            this.Property(t => t.DefaultAccountingDenom).HasColumnName("DefaultAccountingDenom");
            this.Property(t => t.MaximumBet).HasColumnName("MaximumBet");
            this.Property(t => t.SoftwareVersion).HasColumnName("SoftwareVersion");
            this.Property(t => t.ProtocolID).HasColumnName("ProtocolID");
            this.Property(t => t.ProtocolVersionID).HasColumnName("ProtocolVersionID");
            this.Property(t => t.LOCNumber).HasColumnName("LOCNumber");
            this.Property(t => t.TLHashAlgorithmID).HasColumnName("TLHashAlgorithmID");
            this.Property(t => t.TLHashResult).HasColumnName("TLHashResult");
            this.Property(t => t.DateIssued).HasColumnName("DateIssued");
            this.Property(t => t.LOCIssuedByID).HasColumnName("LOCIssuedByID");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.ReviewDate).HasColumnName("ReviewDate");
            this.Property(t => t.CashlessSupported).HasColumnName("CashlessSupported");
            this.Property(t => t.TicketingSupported).HasColumnName("TicketingSupported");
            this.Property(t => t.FundsTransferMethodID).HasColumnName("FundsTransferMethodID");
            this.Property(t => t.CertifiedSoftwareHashingAlgorithmID).HasColumnName("CertifiedSoftwareHashingAlgorithmID");

            // Relationships
            this.HasOptional(t => t.CertifiedSoftwareHashingAlgorithmsCertifiedSoftwareHashingAlgorithm)
                .WithMany(t => t.CertifiedSoftwareHashingAlgorithmsCertifiedModels)
                .HasForeignKey(d => d.CertifiedSoftwareHashingAlgorithmID);
            this.HasOptional(t => t.CertifiedSoftwareHashingAlgorithms1CertifiedSoftwareHashingAlgorithm)
                .WithMany(t => t.CertifiedSoftwareHashingAlgorithms1CertifiedModels)
                .HasForeignKey(d => d.TLHashAlgorithmID);
            this.HasOptional(t => t.CommunicationProtocol)
                .WithMany(t => t.CommunicationProtocolCertifiedModels)
                .HasForeignKey(d => d.ProtocolID);
            this.HasRequired(t => t.CommunicationProtocolVersionsCommunicationProtocolVersion)
                .WithMany(t => t.CommunicationProtocolVersionsCertifiedModels)
                .HasForeignKey(d => d.ProtocolVersionID);
            this.HasOptional(t => t.FundsTransferMethodsFundsTransferMethod)
                .WithMany(t => t.FundsTransferMethodsCertifiedModels)
                .HasForeignKey(d => d.FundsTransferMethodID);
            this.HasOptional(t => t.GameThemesGameTheme)
                .WithMany(t => t.GameThemesCertifiedModels)
                .HasForeignKey(d => d.GameThemeID);
            this.HasRequired(t => t.MachineTypesMachineType)
                .WithMany(t => t.MachineTypesCertifiedModels)
                .HasForeignKey(d => d.MachineTypeID);

        }
    }
}
