using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ApprovalMap : EntityTypeConfiguration<Approval>
    {
        public ApprovalMap()
        {
            // Primary Key
            this.HasKey(t => t.ApprovalID);

            // Properties
            this.Property(t => t.RequestorComments)
                .HasMaxLength(1024);

            this.Property(t => t.ApproverComments)
                .HasMaxLength(1024);

            this.Property(t => t.ApprovalNumber)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Approvals");
            this.Property(t => t.ApprovalID).HasColumnName("ApprovalID");
            this.Property(t => t.ApprovalTypeID).HasColumnName("ApprovalTypeID");
            this.Property(t => t.RequestedByOrganisationID).HasColumnName("RequestedByOrganisationID");
            this.Property(t => t.RequestedByEmployeeID).HasColumnName("RequestedByEmployeeID");
            this.Property(t => t.ApprovedByOrganisationID).HasColumnName("ApprovedByOrganisationID");
            this.Property(t => t.ApprovedByEmployeeID).HasColumnName("ApprovedByEmployeeID");
            this.Property(t => t.DateRequested).HasColumnName("DateRequested");
            this.Property(t => t.DateApproved).HasColumnName("DateApproved");
            this.Property(t => t.RequestorComments).HasColumnName("RequestorComments");
            this.Property(t => t.ApproverComments).HasColumnName("ApproverComments");
            this.Property(t => t.ApprovalNumber).HasColumnName("ApprovalNumber");
            this.Property(t => t.ValidFor).HasColumnName("ValidFor");
            this.Property(t => t.ApprovalStatusID).HasColumnName("ApprovalStatusID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.MovementId).HasColumnName("MovementId");
            this.Property(t => t.InventoryItemID).HasColumnName("InventoryItemID");

            // Relationships
            this.HasOptional(t => t.ApprovalStatusesApprovalStatus)
                .WithMany(t => t.ApprovalStatusesApprovals)
                .HasForeignKey(d => d.ApprovalStatusID);
            this.HasRequired(t => t.ApprovalTypesApprovalType)
                .WithMany(t => t.ApprovalTypesApprovals)
                .HasForeignKey(d => d.ApprovalTypeID);

        }
    }
}
