using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationDeductionMap : EntityTypeConfiguration<OrganisationDeduction>
    {
        public OrganisationDeductionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrganisationID, t.RevenueProfileID, t.FiscalYearID, t.FiscalPeriodID, t.CreditOrganisationID });

            // Properties
            this.Property(t => t.OrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RevenueProfileID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FiscalYearID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FiscalPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreditOrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrganisationDeductions");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.FiscalYearID).HasColumnName("FiscalYearID");
            this.Property(t => t.FiscalPeriodID).HasColumnName("FiscalPeriodID");
            this.Property(t => t.CollectionOrganisationID).HasColumnName("CollectionOrganisationID");
            this.Property(t => t.CreditOrganisationID).HasColumnName("CreditOrganisationID");
            this.Property(t => t.RatePercent).HasColumnName("RatePercent");
            this.Property(t => t.Amount).HasColumnName("Amount");

            // Relationships
            this.HasRequired(t => t.FiscalPeriodsFiscalPeriod)
                .WithMany(t => t.FiscalPeriodsOrganisationDeductions)
                .HasForeignKey(d => new { d.FiscalYearID, d.FiscalPeriodID });
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsOrganisationDeductions)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
