using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class LicenseStatusMap : EntityTypeConfiguration<LicenseStatus>
    {
        public LicenseStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.LicenseStatusID);

            // Properties
            this.Property(t => t.LicenseStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LicenseStatusName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LicenseStatuses");
            this.Property(t => t.LicenseStatusID).HasColumnName("LicenseStatusID");
            this.Property(t => t.LicenseStatusName).HasColumnName("LicenseStatusName");
        }
    }
}
