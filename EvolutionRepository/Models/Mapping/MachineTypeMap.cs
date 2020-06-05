using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MachineTypeMap : EntityTypeConfiguration<MachineType>
    {
        public MachineTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.MachineTypeID);

            // Properties
            this.Property(t => t.MachineTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MachineTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MachineTypes");
            this.Property(t => t.MachineTypeID).HasColumnName("MachineTypeID");
            this.Property(t => t.MachineTypeName).HasColumnName("MachineTypeName");
            this.Property(t => t.IsEDC).HasColumnName("IsEDC");
            this.Property(t => t.IsAssetManaged).HasColumnName("IsAssetManaged");
        }
    }
}
