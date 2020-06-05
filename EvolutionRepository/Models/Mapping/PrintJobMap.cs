using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class PrintJobMap : EntityTypeConfiguration<PrintJob>
    {
        public PrintJobMap()
        {
            // Primary Key
            this.HasKey(t => t.PrintJobID);

            // Properties
            this.Property(t => t.PrintJob1)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("PrintJobs");
            this.Property(t => t.PrintJobID).HasColumnName("PrintJobID");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.PrintJob1).HasColumnName("PrintJob");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.InstructionIssuedAt).HasColumnName("InstructionIssuedAt");
            this.Property(t => t.InstructionID).HasColumnName("InstructionID");

            // Relationships
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsPrintJobs)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
