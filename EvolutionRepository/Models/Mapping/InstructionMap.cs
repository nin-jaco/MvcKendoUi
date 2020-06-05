using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class InstructionMap : EntityTypeConfiguration<Instruction>
    {
        public InstructionMap()
        {
            // Primary Key
            this.HasKey(t => t.InstructionID);

            // Properties
            this.Property(t => t.StatusText)
                .HasMaxLength(1024);

            this.Property(t => t.ProgressText)
                .HasMaxLength(6000);

            this.Property(t => t.CustomParameters)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Instructions");
            this.Property(t => t.InstructionID).HasColumnName("InstructionID");
            this.Property(t => t.IssueTypeID).HasColumnName("IssueTypeID");
            this.Property(t => t.InstructionTypeID).HasColumnName("InstructionTypeID");
            this.Property(t => t.ByOrganisationID).HasColumnName("ByOrganisationID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.InstructionStatusID).HasColumnName("InstructionStatusID");
            this.Property(t => t.StatusText).HasColumnName("StatusText");
            this.Property(t => t.IssuedTime).HasColumnName("IssuedTime");
            this.Property(t => t.ExecutionTime).HasColumnName("ExecutionTime");
            this.Property(t => t.ProgressText).HasColumnName("ProgressText");
            this.Property(t => t.RetriedInstructionID).HasColumnName("RetriedInstructionID");
            this.Property(t => t.MachineCertifiedModelID).HasColumnName("MachineCertifiedModelID");
            this.Property(t => t.SiteServerCertifiedModelID).HasColumnName("SiteServerCertifiedModelID");
            this.Property(t => t.GameServerID).HasColumnName("GameServerID");
            this.Property(t => t.SiteServerID).HasColumnName("SiteServerID");
            this.Property(t => t.CustomParameters).HasColumnName("CustomParameters");

            // Relationships
            this.HasOptional(t => t.EmployeesEmployee)
                .WithMany(t => t.EmployeesInstructions)
                .HasForeignKey(d => d.EmployeeID);
            this.HasRequired(t => t.InstructionIssueTypesInstructionIssueType)
                .WithMany(t => t.InstructionIssueTypesInstructions)
                .HasForeignKey(d => d.IssueTypeID);
            this.HasRequired(t => t.InstructionStatusInstructionStatu)
                .WithMany(t => t.InstructionStatusInstructions)
                .HasForeignKey(d => d.InstructionStatusID);
            this.HasOptional(t => t.InstructionTypesInstructionType)
                .WithMany(t => t.InstructionTypesInstructions)
                .HasForeignKey(d => d.InstructionTypeID);
            this.HasOptional(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsInstructions)
                .HasForeignKey(d => d.ByOrganisationID);
            this.HasRequired(t => t.Organisations1Organisation)
                .WithMany(t => t.Organisations1Instructions)
                .HasForeignKey(d => d.SiteID);

        }
    }
}
