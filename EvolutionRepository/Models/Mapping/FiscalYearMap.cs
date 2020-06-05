using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class FiscalYearMap : EntityTypeConfiguration<FiscalYear>
    {
        public FiscalYearMap()
        {
            // Primary Key
            this.HasKey(t => t.FiscalYearID);

            // Properties
            this.Property(t => t.FiscalYearName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FiscalYears");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.FiscalYearID).HasColumnName("FiscalYearID");
            this.Property(t => t.FiscalPeriodTypeID).HasColumnName("FiscalPeriodTypeID");
            this.Property(t => t.FiscalYearName).HasColumnName("FiscalYearName");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.FiscalPeriodDaysGrace).HasColumnName("FiscalPeriodDaysGrace");
            this.Property(t => t.DateProcessed).HasColumnName("DateProcessed");

            // Relationships
            this.HasRequired(t => t.FiscalPeriodTypesFiscalPeriodType)
                .WithMany(t => t.FiscalPeriodTypesFiscalYears)
                .HasForeignKey(d => d.FiscalPeriodTypeID);
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsFiscalYears)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
