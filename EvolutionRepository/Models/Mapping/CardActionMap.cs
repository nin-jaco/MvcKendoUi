using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CardActionMap : EntityTypeConfiguration<CardAction>
    {
        public CardActionMap()
        {
            // Primary Key
            this.HasKey(t => t.CardActionID);

            // Properties
            this.Property(t => t.CardActionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardActionName)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("CardActions");
            this.Property(t => t.CardActionID).HasColumnName("CardActionID");
            this.Property(t => t.CardActionName).HasColumnName("CardActionName");
        }
    }
}
