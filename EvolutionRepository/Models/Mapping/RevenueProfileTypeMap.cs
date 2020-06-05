using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class RevenueProfileTypeMap : EntityTypeConfiguration<RevenueProfileType>
    {
        public RevenueProfileTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.RevenueProfileTypeID);

            // Properties
            this.Property(t => t.RevenueProfileTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RevenueProfileTypeName)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.TotalFunction)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.TotalTableName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TotalFieldName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RevenueProfileTypes");
            this.Property(t => t.RevenueProfileTypeID).HasColumnName("RevenueProfileTypeID");
            this.Property(t => t.RevenueProfileTypeName).HasColumnName("RevenueProfileTypeName");
            this.Property(t => t.TotalFunction).HasColumnName("TotalFunction");
            this.Property(t => t.TotalTableName).HasColumnName("TotalTableName");
            this.Property(t => t.TotalFieldName).HasColumnName("TotalFieldName");
        }
    }
}
