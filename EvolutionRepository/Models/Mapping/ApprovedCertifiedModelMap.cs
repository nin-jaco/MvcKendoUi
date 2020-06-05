using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ApprovedCertifiedModelMap : EntityTypeConfiguration<ApprovedCertifiedModel>
    {
        public ApprovedCertifiedModelMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrganisationID, t.CertifiedModelID });

            // Properties
            this.Property(t => t.OrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CertifiedModelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ApprovalNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ApprovedCertifiedModels");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.ApprovalNumber).HasColumnName("ApprovalNumber");

            // Relationships
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsApprovedCertifiedModels)
                .HasForeignKey(d => d.OrganisationID);

        }
    }
}
