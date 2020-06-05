using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class SiteDisabledPeriodMap : EntityTypeConfiguration<SiteDisabledPeriod>
    {
        public SiteDisabledPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodID);

            // Properties
            this.Property(t => t.PeriodName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SiteDisabledPeriods");
            this.Property(t => t.PeriodID).HasColumnName("PeriodID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.PeriodName).HasColumnName("PeriodName");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.FrequencyTypeID).HasColumnName("FrequencyTypeID");
            this.Property(t => t.FrequencyInterval).HasColumnName("FrequencyInterval");
            this.Property(t => t.DisableStartDate).HasColumnName("DisableStartDate");
            this.Property(t => t.DisableEndDate).HasColumnName("DisableEndDate");

            // Relationships
            this.HasRequired(t => t.FrequencyType)
                .WithMany(t => t.FrequencyTypeSiteDisabledPeriods)
                .HasForeignKey(d => d.FrequencyTypeID);

        }
    }
}
