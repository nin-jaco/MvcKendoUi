using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CEMSUtilLogMap : EntityTypeConfiguration<CEMSUtilLog>
    {
        public CEMSUtilLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CEMSUtilLogID, t.EmployeeID, t.CEMSUtilLogActionID, t.Date });

            // Properties
            this.Property(t => t.CEMSUtilLogID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CEMSUtilLogActionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FunctionalArea)
                .HasMaxLength(128);

            this.Property(t => t.Description)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("CEMSUtilLogs");
            this.Property(t => t.CEMSUtilLogID).HasColumnName("CEMSUtilLogID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.CEMSUtilLogActionID).HasColumnName("CEMSUtilLogActionID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.FunctionalArea).HasColumnName("FunctionalArea");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
