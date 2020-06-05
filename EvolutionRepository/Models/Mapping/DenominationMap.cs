using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class DenominationMap : EntityTypeConfiguration<Denomination>
    {
        public DenominationMap()
        {
            // Primary Key
            this.HasKey(t => t.DenominationID);

            // Properties
            this.Property(t => t.DenominationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DenominationName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Denominations");
            this.Property(t => t.DenominationID).HasColumnName("DenominationID");
            this.Property(t => t.DenominationName).HasColumnName("DenominationName");
            this.Property(t => t.DenominationTypeID).HasColumnName("DenominationTypeID");
            this.Property(t => t.UnitValue).HasColumnName("UnitValue");

            // Relationships
            this.HasRequired(t => t.DenominationTypesDenominationType)
                .WithMany(t => t.DenominationTypesDenominations)
                .HasForeignKey(d => d.DenominationTypeID);

        }
    }
}
