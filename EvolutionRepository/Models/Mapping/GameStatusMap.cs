using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class GameStatusMap : EntityTypeConfiguration<GameStatus>
    {
        public GameStatusMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MachineID, t.CertifiedSoftwareID, t.GameID });

            // Properties
            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CertifiedSoftwareID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GameID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("GameStatus");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.CertifiedSoftwareID).HasColumnName("CertifiedSoftwareID");
            this.Property(t => t.GameID).HasColumnName("GameID");
            this.Property(t => t.RTP).HasColumnName("RTP");
            this.Property(t => t.gameStatus).HasColumnName("GameStatus");
        }
    }
}
