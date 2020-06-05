using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressID);

            // Properties
            this.Property(t => t.AddressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressLine1)
                .HasMaxLength(50);

            this.Property(t => t.AddressLine2)
                .HasMaxLength(50);

            this.Property(t => t.AddressLine3)
                .HasMaxLength(50);

            this.Property(t => t.AddressLine4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Addresses");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.JurisdictionID).HasColumnName("JurisdictionID");
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
            this.Property(t => t.AddressLine3).HasColumnName("AddressLine3");
            this.Property(t => t.AddressLine4).HasColumnName("AddressLine4");
        }
    }
}
