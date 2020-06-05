using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CardListMap : EntityTypeConfiguration<CardList>
    {
        public CardListMap()
        {
            // Primary Key
            this.HasKey(t => t.CardListID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CardLists");
            this.Property(t => t.CardListID).HasColumnName("CardListID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.IsPending).HasColumnName("IsPending");
            this.Property(t => t.SDLUpdatedTime).HasColumnName("SDLUpdatedTime");
            this.Property(t => t.InstructionID).HasColumnName("InstructionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");

            // Relationships
            this.HasMany(t => t.CardListCardsCards)
                .WithMany(t => t.CardListCardsCardLists)
                .Map(m =>
                    {
                        m.ToTable("CardListCards");
                        m.MapLeftKey("CardListID");
                        m.MapRightKey("CardID");
                    });

            this.HasRequired(t => t.InstructionsInstruction)
                .WithMany(t => t.InstructionsCardLists)
                .HasForeignKey(d => d.InstructionID);
            this.HasRequired(t => t.SitesSite)
                .WithMany(t => t.SitesCardLists)
                .HasForeignKey(d => d.SiteID);

        }
    }
}
