using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class JurisdictionTypeMap : EntityTypeConfiguration<JurisdictionType>
    {
        public JurisdictionTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.JurisdictionTypeID);

            // Properties
            this.Property(t => t.JurisdictionTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.JurisdictionTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("JurisdictionTypes");
            this.Property(t => t.JurisdictionTypeID).HasColumnName("JurisdictionTypeID");
            this.Property(t => t.JurisdictionTypeName).HasColumnName("JurisdictionTypeName");
        }
    }
}
