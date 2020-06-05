using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class LifeCycleStatuMap : EntityTypeConfiguration<LifeCycleStatu>
    {
        public LifeCycleStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.LifeCycleStatusId);

            // Properties
            this.Property(t => t.LifeCycleStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LifeCycleStatusName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LifeCycleStatus");
            this.Property(t => t.LifeCycleStatusId).HasColumnName("LifeCycleStatusId");
            this.Property(t => t.LifeCycleStatusName).HasColumnName("LifeCycleStatusName");
            this.Property(t => t.IsVisible).HasColumnName("IsVisible");
        }
    }
}
