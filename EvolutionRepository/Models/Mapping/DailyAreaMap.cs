using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class DailyAreaMap : EntityTypeConfiguration<DailyArea>
    {
        public DailyAreaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ApplicableDate, t.OrganisationID, t.AreaID, t.AreaManagerID, t.AccountManagerID, t.MachineID, t.ModelID });

            // Properties
            this.Property(t => t.OrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AreaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AreaManagerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AccountManagerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DailyAreas");
            this.Property(t => t.ApplicableDate).HasColumnName("ApplicableDate");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.AreaManagerID).HasColumnName("AreaManagerID");
            this.Property(t => t.AccountManagerID).HasColumnName("AccountManagerID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.ModelID).HasColumnName("ModelID");

            // Relationships
            this.HasRequired(t => t.AreasArea)
                .WithMany(t => t.AreasDailyAreas)
                .HasForeignKey(d => d.AreaID);
            this.HasRequired(t => t.EmployeesEmployee)
                .WithMany(t => t.EmployeesDailyAreas)
                .HasForeignKey(d => d.AreaManagerID);
            this.HasRequired(t => t.Employees1Employee)
                .WithMany(t => t.Employees1DailyAreas)
                .HasForeignKey(d => d.AccountManagerID);
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsDailyAreas)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
