using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class FiscalPeriodTypeMap : EntityTypeConfiguration<FiscalPeriodType>
    {
        public FiscalPeriodTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.FiscalPeriodTypeID);

            // Properties
            this.Property(t => t.FiscalPeriodTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FiscalPeriodTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FiscalPeriodTypes");
            this.Property(t => t.FiscalPeriodTypeID).HasColumnName("FiscalPeriodTypeID");
            this.Property(t => t.FiscalPeriodTypeName).HasColumnName("FiscalPeriodTypeName");
            this.Property(t => t.IsCalculatedAtEnd).HasColumnName("IsCalculatedAtEnd");
            this.Property(t => t.IsBasedOnPrevious).HasColumnName("IsBasedOnPrevious");
        }
    }
}
