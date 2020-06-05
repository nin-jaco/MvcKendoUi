using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class SiteDeletedCardMap : EntityTypeConfiguration<SiteDeletedCard>
    {
        public SiteDeletedCardMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SiteID, t.CardID });

            // Properties
            this.Property(t => t.SiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SiteDeletedCards");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.CardID).HasColumnName("CardID");
            this.Property(t => t.DateDeleted).HasColumnName("DateDeleted");
            this.Property(t => t.InstructionID).HasColumnName("InstructionID");
        }
    }
}
