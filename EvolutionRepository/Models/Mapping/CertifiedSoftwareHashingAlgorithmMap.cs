using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CertifiedSoftwareHashingAlgorithmMap : EntityTypeConfiguration<CertifiedSoftwareHashingAlgorithm>
    {
        public CertifiedSoftwareHashingAlgorithmMap()
        {
            // Primary Key
            this.HasKey(t => t.CertifiedSoftwareHashingAlgorithmID);

            // Properties
            this.Property(t => t.CertifiedSoftwareHashingAlgorithmID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CertifiedSoftwareHashingAlgorithmName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CertifiedSoftwareHashingAlgorithms");
            this.Property(t => t.CertifiedSoftwareHashingAlgorithmID).HasColumnName("CertifiedSoftwareHashingAlgorithmID");
            this.Property(t => t.CertifiedSoftwareHashingAlgorithmName).HasColumnName("CertifiedSoftwareHashingAlgorithmName");
        }
    }
}
