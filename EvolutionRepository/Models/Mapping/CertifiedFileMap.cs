using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CertifiedFileMap : EntityTypeConfiguration<CertifiedFile>
    {
        public CertifiedFileMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CertifiedModelID, t.BinaryFileName });

            // Properties
            this.Property(t => t.CertifiedModelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BinaryFileName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HashValue)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("CertifiedFiles");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");
            this.Property(t => t.BinaryFileName).HasColumnName("BinaryFileName");
            this.Property(t => t.BinaryCheckOrder).HasColumnName("BinaryCheckOrder");
            this.Property(t => t.FileVersion).HasColumnName("FileVersion");
            this.Property(t => t.HashValue).HasColumnName("HashValue");

            // Relationships
            this.HasRequired(t => t.CertifiedModelsCertifiedModel)
                .WithMany(t => t.CertifiedModelsCertifiedFiles)
                .HasForeignKey(d => d.CertifiedModelID);

        }
    }
}
