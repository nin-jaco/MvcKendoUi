using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CabinetMap : EntityTypeConfiguration<Cabinet>
    {
        public CabinetMap()
        {
            // Primary Key
            this.HasKey(t => t.CabinetID);

            // Properties
            this.Property(t => t.CabinetID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CabinetName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Cabinets");
            this.Property(t => t.CabinetID).HasColumnName("CabinetID");
            this.Property(t => t.CabinetName).HasColumnName("CabinetName");
            this.Property(t => t.ManufacturerID).HasColumnName("ManufacturerID");

            // Relationships
            this.HasMany(t => t.CertifiedModelCabinetsCertifiedModels)
                .WithMany(t => t.CertifiedModelCabinetsCabinets)
                .Map(m =>
                    {
                        m.ToTable("CertifiedModelCabinets");
                        m.MapLeftKey("CabinetID");
                        m.MapRightKey("CertifiedModelID");
                    });


        }
    }
}
