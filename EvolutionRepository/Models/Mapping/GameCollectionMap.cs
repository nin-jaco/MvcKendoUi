using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class GameCollectionMap : EntityTypeConfiguration<GameCollection>
    {
        public GameCollectionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MachineID, t.GameID, t.CollectionEndTime });

            // Properties
            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GameID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("GameCollections");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");
            this.Property(t => t.GameID).HasColumnName("GameID");
            this.Property(t => t.CollectionStartTime).HasColumnName("CollectionStartTime");
            this.Property(t => t.CollectionEndTime).HasColumnName("CollectionEndTime");
            this.Property(t => t.GMGameType).HasColumnName("GMGameType");
            this.Property(t => t.PlayerDenom).HasColumnName("PlayerDenom");
            this.Property(t => t.CurrentRTP).HasColumnName("CurrentRTP");
            this.Property(t => t.TotalBet).HasColumnName("TotalBet");
            this.Property(t => t.TotalWin).HasColumnName("TotalWin");
            this.Property(t => t.TotalGamesPlayed).HasColumnName("TotalGamesPlayed");
            this.Property(t => t.TotalGamesWon).HasColumnName("TotalGamesWon");
            this.Property(t => t.MaximumBet).HasColumnName("MaximumBet");
            this.Property(t => t.MaximumWin).HasColumnName("MaximumWin");
            this.Property(t => t.DateMigrated).HasColumnName("DateMigrated");
        }
    }
}
