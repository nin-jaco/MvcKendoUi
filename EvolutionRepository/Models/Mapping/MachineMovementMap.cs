using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MachineMovementMap : EntityTypeConfiguration<MachineMovement>
    {
        public MachineMovementMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MovementID, t.MovementLegID });

            // Properties
            this.Property(t => t.MovementID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MovementLegID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MachineMovements");
            this.Property(t => t.MovementID).HasColumnName("MovementID");
            this.Property(t => t.MovementLegID).HasColumnName("MovementLegID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.InventoryItemID).HasColumnName("InventoryItemID");
            this.Property(t => t.FromSiteID).HasColumnName("FromSiteID");
            this.Property(t => t.FromSiteArrivalTime).HasColumnName("FromSiteArrivalTime");
            this.Property(t => t.FromSiteDepartureTime).HasColumnName("FromSiteDepartureTime");
            this.Property(t => t.ToSiteID).HasColumnName("ToSiteID");
            this.Property(t => t.ToSiteArrivalTime).HasColumnName("ToSiteArrivalTime");
            this.Property(t => t.ToSiteDepartureTime).HasColumnName("ToSiteDepartureTime");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");

            // Relationships
            this.HasRequired(t => t.MovementsMovement)
                .WithMany(t => t.MovementsMachineMovements)
                .HasForeignKey(d => d.MovementID);

        }
    }
}
