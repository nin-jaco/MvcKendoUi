using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class PhotoLibraryMap : EntityTypeConfiguration<PhotoLibrary>
    {
        public PhotoLibraryMap()
        {
            // Primary Key
            this.HasKey(t => t.PhotoID);

            // Properties
            this.Property(t => t.Key_)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.upsize_ts)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("PhotoLibrary");
            this.Property(t => t.PhotoID).HasColumnName("PhotoID");
            this.Property(t => t.Key_).HasColumnName("Key_");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.upsize_ts).HasColumnName("upsize_ts");
        }
    }
}
