using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MovementMap : EntityTypeConfiguration<Movement>
    {
        public MovementMap()
        {
            // Primary Key
            this.HasKey(t => t.MovementID);

            // Properties
            this.Property(t => t.RequestorComments)
                .HasMaxLength(500);

            this.Property(t => t.ApprovalNumber)
                .HasMaxLength(20);

            this.Property(t => t.ApproverComments)
                .HasMaxLength(500);

            this.Property(t => t.Timestamp)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Movements");
            this.Property(t => t.MovementID).HasColumnName("MovementID");
            this.Property(t => t.MovementTypeID).HasColumnName("MovementTypeID");
            this.Property(t => t.MovementStatusID).HasColumnName("MovementStatusID");
            this.Property(t => t.ServiceCallID).HasColumnName("ServiceCallID");
            this.Property(t => t.RequestorID).HasColumnName("RequestorID");
            this.Property(t => t.RequestorComments).HasColumnName("RequestorComments");
            this.Property(t => t.DateRequested).HasColumnName("DateRequested");
            this.Property(t => t.DueInstallationDate).HasColumnName("DueInstallationDate");
            this.Property(t => t.ApprovalNumber).HasColumnName("ApprovalNumber");
            this.Property(t => t.ApproverID).HasColumnName("ApproverID");
            this.Property(t => t.ApproverComments).HasColumnName("ApproverComments");
            this.Property(t => t.DateApproved).HasColumnName("DateApproved");
            this.Property(t => t.DateCompleted).HasColumnName("DateCompleted");
            this.Property(t => t.OwnerID).HasColumnName("OwnerID");
            this.Property(t => t.ManagedByID).HasColumnName("ManagedByID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");

            // Relationships
            this.HasOptional(t => t.MovementStatusMovementStatu)
                .WithMany(t => t.MovementStatusMovements)
                .HasForeignKey(d => d.MovementStatusID);
            this.HasOptional(t => t.MovementTypesMovementType)
                .WithMany(t => t.MovementTypesMovements)
                .HasForeignKey(d => d.MovementTypeID);

        }
    }
}
