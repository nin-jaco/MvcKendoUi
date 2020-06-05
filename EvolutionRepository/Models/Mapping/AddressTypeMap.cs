using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AddressTypeMap : EntityTypeConfiguration<AddressType>
    {
        public AddressTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressTypeID);

            // Properties
            this.Property(t => t.AddressTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AddressTypes");
            this.Property(t => t.AddressTypeID).HasColumnName("AddressTypeID");
            this.Property(t => t.AddressTypeName).HasColumnName("AddressTypeName");
        }
    }
}
