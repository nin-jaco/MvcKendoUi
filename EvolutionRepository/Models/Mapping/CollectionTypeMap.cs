using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CollectionTypeMap : EntityTypeConfiguration<CollectionType>
    {
        public CollectionTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CollectionTypeID);

            // Properties
            this.Property(t => t.CollectionTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CollectionTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CollectionTypes");
            this.Property(t => t.CollectionTypeID).HasColumnName("CollectionTypeID");
            this.Property(t => t.CollectionTypeName).HasColumnName("CollectionTypeName");
        }
    }
}
