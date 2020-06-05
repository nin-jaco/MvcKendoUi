using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class RevenueScaleMap : EntityTypeConfiguration<RevenueScale>
    {
        public RevenueScaleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RevenueProfileID, t.RevenueScaleID });

            // Properties
            this.Property(t => t.RevenueProfileID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RevenueScaleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RevenueScales");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.RevenueScaleID).HasColumnName("RevenueScaleID");
            this.Property(t => t.FixedAmount).HasColumnName("FixedAmount");
            this.Property(t => t.Limit).HasColumnName("Limit");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.DateDeleted).HasColumnName("DateDeleted");

            // Relationships
            this.HasRequired(t => t.RevenueProfilesRevenueProfile)
                .WithMany(t => t.RevenueProfilesRevenueScales)
                .HasForeignKey(d => d.RevenueProfileID);

        }
    }
}
