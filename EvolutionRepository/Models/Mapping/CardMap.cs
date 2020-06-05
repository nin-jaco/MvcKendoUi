using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CardMap : EntityTypeConfiguration<Card>
    {
        public CardMap()
        {
            // Primary Key
            this.HasKey(t => t.CardID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Cards");
            this.Property(t => t.CardID).HasColumnName("CardID");
            this.Property(t => t.CardTypeID).HasColumnName("CardTypeID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.OperatorID).HasColumnName("OperatorID");
            this.Property(t => t.JurisdictionID).HasColumnName("JurisdictionID");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");

            // Relationships
            this.HasRequired(t => t.CardTypesCardType)
                .WithMany(t => t.CardTypesCards)
                .HasForeignKey(d => d.CardTypeID);
            this.HasRequired(t => t.EmployeesEmployee)
                .WithMany(t => t.EmployeesCards)
                .HasForeignKey(d => d.EmployeeID);

        }
    }
}
