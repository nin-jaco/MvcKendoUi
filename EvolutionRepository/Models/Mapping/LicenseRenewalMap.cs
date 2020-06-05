using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class LicenseRenewalMap : EntityTypeConfiguration<LicenseRenewal>
    {
        public LicenseRenewalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LicenseID, t.StartDate });

            // Properties
            this.Property(t => t.LicenseID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("LicenseRenewals");
            this.Property(t => t.LicenseID).HasColumnName("LicenseID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.ExpiryDate).HasColumnName("ExpiryDate");
            this.Property(t => t.HasPaid).HasColumnName("HasPaid");

            // Relationships
            this.HasRequired(t => t.LicensesLicense)
                .WithMany(t => t.LicensesLicenseRenewals)
                .HasForeignKey(d => d.LicenseID);

        }
    }
}
