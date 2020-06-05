using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class PINUpdateMap : EntityTypeConfiguration<PINUpdate>
    {
        public PINUpdateMap()
        {
            // Primary Key
            this.HasKey(t => t.PINUpdateID);

            // Properties
            this.Property(t => t.PINUpdateID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PINUpateDescription)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("PINUpdates");
            this.Property(t => t.PINUpdateID).HasColumnName("PINUpdateID");
            this.Property(t => t.PINUpateDescription).HasColumnName("PINUpateDescription");
        }
    }
}
