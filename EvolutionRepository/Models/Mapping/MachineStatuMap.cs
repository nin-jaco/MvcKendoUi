using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MachineStatuMap : EntityTypeConfiguration<MachineStatu>
    {
        public MachineStatuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MachineID, t.StatusTime });

            // Properties
            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MachineStatus");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.MachineStatus).HasColumnName("MachineStatus");
            this.Property(t => t.PlayerCredit).HasColumnName("PlayerCredit");
            this.Property(t => t.PlayerBet).HasColumnName("PlayerBet");
            this.Property(t => t.PlayerWin).HasColumnName("PlayerWin");
            this.Property(t => t.DoorOpenStatus).HasColumnName("DoorOpenStatus");
            this.Property(t => t.MachineMode).HasColumnName("MachineMode");
            this.Property(t => t.CurrentQueueSize).HasColumnName("CurrentQueueSize");
            this.Property(t => t.MaximumQueueSize).HasColumnName("MaximumQueueSize");
            this.Property(t => t.StatusTime).HasColumnName("StatusTime");
        }
    }
}
