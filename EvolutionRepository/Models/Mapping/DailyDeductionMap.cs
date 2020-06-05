using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class DailyDeductionMap : EntityTypeConfiguration<DailyDeduction>
    {
        public DailyDeductionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MachineID, t.ApplicableDate, t.RevenueProfileID, t.SiteID, t.CreditOrganisationID });

            // Properties
            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RevenueProfileID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreditOrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DailyDeductions");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.ApplicableDate).HasColumnName("ApplicableDate");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.CollectionOrganisationID).HasColumnName("CollectionOrganisationID");
            this.Property(t => t.CreditOrganisationID).HasColumnName("CreditOrganisationID");
            this.Property(t => t.RatePercent).HasColumnName("RatePercent");
            this.Property(t => t.Amount).HasColumnName("Amount");
        }
    }
}
