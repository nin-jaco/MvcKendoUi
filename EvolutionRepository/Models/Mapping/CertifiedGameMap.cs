using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CertifiedGameMap : EntityTypeConfiguration<CertifiedGame>
    {
        public CertifiedGameMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CertifiedModelID, t.CertifiedGameID });

            // Properties
            this.Property(t => t.CertifiedModelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CertifiedGameID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CertifiedGameName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CertifiedGames");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");
            this.Property(t => t.CertifiedGameID).HasColumnName("CertifiedGameID");
            this.Property(t => t.CertifiedGameName).HasColumnName("CertifiedGameName");
            this.Property(t => t.PlayerDenom).HasColumnName("PlayerDenom");
            this.Property(t => t.MinimumBet).HasColumnName("MinimumBet");
            this.Property(t => t.MaximumBet).HasColumnName("MaximumBet");
            this.Property(t => t.MinimumRTP).HasColumnName("MinimumRTP");
            this.Property(t => t.MaximumRTP).HasColumnName("MaximumRTP");

            // Relationships
            this.HasRequired(t => t.CertifiedModelsCertifiedModel)
                .WithMany(t => t.CertifiedModelsCertifiedGames)
                .HasForeignKey(d => d.CertifiedModelID);

        }
    }
}
