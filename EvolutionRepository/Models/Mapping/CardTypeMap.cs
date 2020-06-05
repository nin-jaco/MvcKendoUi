using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CardTypeMap : EntityTypeConfiguration<CardType>
    {
        public CardTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CardTypeID);

            // Properties
            this.Property(t => t.CardTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardTypeName)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("CardTypes");
            this.Property(t => t.CardTypeID).HasColumnName("CardTypeID");
            this.Property(t => t.CardTypeName).HasColumnName("CardTypeName");
        }
    }
}
