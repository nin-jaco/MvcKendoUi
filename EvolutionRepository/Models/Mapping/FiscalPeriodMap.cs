using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class FiscalPeriodMap : EntityTypeConfiguration<FiscalPeriod>
    {
        public FiscalPeriodMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FiscalYearID, t.FiscalPeriodID });

            // Properties
            this.Property(t => t.FiscalYearID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FiscalPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FiscalPeriodName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FiscalPeriods");
            this.Property(t => t.FiscalYearID).HasColumnName("FiscalYearID");
            this.Property(t => t.FiscalPeriodID).HasColumnName("FiscalPeriodID");
            this.Property(t => t.FiscalPeriodName).HasColumnName("FiscalPeriodName");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.DateProcessed).HasColumnName("DateProcessed");

            // Relationships
            this.HasRequired(t => t.FiscalYearsFiscalYear)
                .WithMany(t => t.FiscalYearsFiscalPeriods)
                .HasForeignKey(d => d.FiscalYearID);

        }
    }
}
