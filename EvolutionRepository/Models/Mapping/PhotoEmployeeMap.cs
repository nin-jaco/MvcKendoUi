using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class PhotoEmployeeMap : EntityTypeConfiguration<PhotoEmployee>
    {
        public PhotoEmployeeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PhotoID, t.PhotoTypeID, t.EmployeeID });

            // Properties
            this.Property(t => t.PhotoID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PhotoTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.upsize_ts)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("PhotoEmployees");
            this.Property(t => t.PhotoID).HasColumnName("PhotoID");
            this.Property(t => t.PhotoTypeID).HasColumnName("PhotoTypeID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.upsize_ts).HasColumnName("upsize_ts");

            // Relationships
            this.HasRequired(t => t.EmployeesEmployee)
                .WithMany(t => t.EmployeesPhotoEmployees)
                .HasForeignKey(d => d.EmployeeID);

        }
    }
}
