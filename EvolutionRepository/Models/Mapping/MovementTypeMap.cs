using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MovementTypeMap : EntityTypeConfiguration<MovementType>
    {
        public MovementTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.MovementTypeID);

            // Properties
            this.Property(t => t.MovementTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MovementTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MovementTypes");
            this.Property(t => t.MovementTypeID).HasColumnName("MovementTypeID");
            this.Property(t => t.MovementTypeName).HasColumnName("MovementTypeName");
            this.Property(t => t.IsInventoryItem).HasColumnName("IsInventoryItem");
            this.Property(t => t.IsSystemOnly).HasColumnName("IsSystemOnly");
            this.Property(t => t.RequestorOrganisationTypeID).HasColumnName("RequestorOrganisationTypeID");
            this.Property(t => t.ApproverOrganisationTypeID).HasColumnName("ApproverOrganisationTypeID");
        }
    }
}
