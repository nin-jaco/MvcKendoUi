using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CertifiedFileHashResultMap : EntityTypeConfiguration<CertifiedFileHashResult>
    {
        public CertifiedFileHashResultMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CertifiedModelID, t.BinaryFileName, t.Seed });

            // Properties
            this.Property(t => t.CertifiedModelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BinaryFileName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Seed)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Result)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("CertifiedFileHashResults");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");
            this.Property(t => t.BinaryFileName).HasColumnName("BinaryFileName");
            this.Property(t => t.Seed).HasColumnName("Seed");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.GeneratedDate).HasColumnName("GeneratedDate");

            // Relationships
            this.HasRequired(t => t.CertifiedFilesCertifiedFile)
                .WithMany(t => t.CertifiedFilesCertifiedFileHashResults)
                .HasForeignKey(d => new { d.CertifiedModelID, d.BinaryFileName });

        }
    }
}
