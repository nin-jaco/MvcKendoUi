using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ActionMap : EntityTypeConfiguration<Action>
    {
        public ActionMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionID);

            // Properties
            this.Property(t => t.ActionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ActionName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MenuName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Actions");
            this.Property(t => t.ActionID).HasColumnName("ActionID");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
            this.Property(t => t.MenuName).HasColumnName("MenuName");
            this.Property(t => t.IsMDI).HasColumnName("IsMDI");
        }
    }
}
