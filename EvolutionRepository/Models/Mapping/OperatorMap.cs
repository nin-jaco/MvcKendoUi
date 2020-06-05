using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OperatorMap : EntityTypeConfiguration<Operator>
    {
        public OperatorMap()
        {
            // Primary Key
            this.HasKey(t => t.OperatorID);

            // Properties
            this.Property(t => t.OperatorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Operators");
            this.Property(t => t.OperatorID).HasColumnName("OperatorID");
            this.Property(t => t.IsRouteOperator).HasColumnName("IsRouteOperator");
            this.Property(t => t.IsServiceProvider).HasColumnName("IsServiceProvider");
            this.Property(t => t.IsSupplier).HasColumnName("IsSupplier");
            this.Property(t => t.IsManufacturer).HasColumnName("IsManufacturer");

            // Relationships
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithOptional(t => t.OrganisationsOperator);

        }
    }
}
