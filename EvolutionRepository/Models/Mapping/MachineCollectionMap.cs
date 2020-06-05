using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MachineCollectionMap : EntityTypeConfiguration<MachineCollection>
    {
        public MachineCollectionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CollectionEndTime, t.MachineID });

            // Properties
            this.Property(t => t.SoftwareVersion)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProtocolVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("MachineCollections");
            this.Property(t => t.CollectionEndTime).HasColumnName("CollectionEndTime");
            this.Property(t => t.CollectionStartTime).HasColumnName("CollectionStartTime");
            this.Property(t => t.MachineType).HasColumnName("MachineType");
            this.Property(t => t.GameType).HasColumnName("GameType");
            this.Property(t => t.SoftwareVersion).HasColumnName("SoftwareVersion");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.ProtocolVersion).HasColumnName("ProtocolVersion");
            this.Property(t => t.MaximumBet).HasColumnName("MaximumBet");
            this.Property(t => t.AccountingDenom).HasColumnName("AccountingDenom");
            this.Property(t => t.TargetPercentage).HasColumnName("TargetPercentage");
            this.Property(t => t.CoinsIn10c).HasColumnName("CoinsIn10c");
            this.Property(t => t.CoinsIn20c).HasColumnName("CoinsIn20c");
            this.Property(t => t.CoinsIn50c).HasColumnName("CoinsIn50c");
            this.Property(t => t.CoinsIn100c).HasColumnName("CoinsIn100c");
            this.Property(t => t.CoinsIn200c).HasColumnName("CoinsIn200c");
            this.Property(t => t.CoinsIn500c).HasColumnName("CoinsIn500c");
            this.Property(t => t.CoinsIn1000c).HasColumnName("CoinsIn1000c");
            this.Property(t => t.CoinsIn2000c).HasColumnName("CoinsIn2000c");
            this.Property(t => t.CoinsIn5000c).HasColumnName("CoinsIn5000c");
            this.Property(t => t.CoinDrop10c).HasColumnName("CoinDrop10c");
            this.Property(t => t.CoinDrop20c).HasColumnName("CoinDrop20c");
            this.Property(t => t.CoinDrop50c).HasColumnName("CoinDrop50c");
            this.Property(t => t.CoinDrop100c).HasColumnName("CoinDrop100c");
            this.Property(t => t.CoinDrop200c).HasColumnName("CoinDrop200c");
            this.Property(t => t.CoinDrop500c).HasColumnName("CoinDrop500c");
            this.Property(t => t.CoinDrop1000c).HasColumnName("CoinDrop1000c");
            this.Property(t => t.CoinDrop2000c).HasColumnName("CoinDrop2000c");
            this.Property(t => t.CoinDrop5000c).HasColumnName("CoinDrop5000c");
            this.Property(t => t.CoinRefill10c).HasColumnName("CoinRefill10c");
            this.Property(t => t.CoinRefill20c).HasColumnName("CoinRefill20c");
            this.Property(t => t.CoinRefill50c).HasColumnName("CoinRefill50c");
            this.Property(t => t.CoinRefill100c).HasColumnName("CoinRefill100c");
            this.Property(t => t.CoinRefill200c).HasColumnName("CoinRefill200c");
            this.Property(t => t.CoinRefill500c).HasColumnName("CoinRefill500c");
            this.Property(t => t.CoinRefill1000c).HasColumnName("CoinRefill1000c");
            this.Property(t => t.CoinRefill2000c).HasColumnName("CoinRefill2000c");
            this.Property(t => t.CoinRefill5000c).HasColumnName("CoinRefill5000c");
            this.Property(t => t.CoinOut10c).HasColumnName("CoinOut10c");
            this.Property(t => t.CoinOut20c).HasColumnName("CoinOut20c");
            this.Property(t => t.CoinOut50c).HasColumnName("CoinOut50c");
            this.Property(t => t.CoinOut100c).HasColumnName("CoinOut100c");
            this.Property(t => t.CoinOut200c).HasColumnName("CoinOut200c");
            this.Property(t => t.CoinOut500c).HasColumnName("CoinOut500c");
            this.Property(t => t.CoinOut1000c).HasColumnName("CoinOut1000c");
            this.Property(t => t.CoinOut2000c).HasColumnName("CoinOut2000c");
            this.Property(t => t.CoinOut5000c).HasColumnName("CoinOut5000c");
            this.Property(t => t.NoteIn10).HasColumnName("NoteIn10");
            this.Property(t => t.NoteIn20).HasColumnName("NoteIn20");
            this.Property(t => t.NoteIn50).HasColumnName("NoteIn50");
            this.Property(t => t.NoteIn100).HasColumnName("NoteIn100");
            this.Property(t => t.NoteIn200).HasColumnName("NoteIn200");
            this.Property(t => t.NoteIn500).HasColumnName("NoteIn500");
            this.Property(t => t.NoteIn1000).HasColumnName("NoteIn1000");
            this.Property(t => t.NoteDrop10).HasColumnName("NoteDrop10");
            this.Property(t => t.NoteDrop20).HasColumnName("NoteDrop20");
            this.Property(t => t.NoteDrop50).HasColumnName("NoteDrop50");
            this.Property(t => t.NoteDrop100).HasColumnName("NoteDrop100");
            this.Property(t => t.NoteDrop200).HasColumnName("NoteDrop200");
            this.Property(t => t.NoteDrop500).HasColumnName("NoteDrop500");
            this.Property(t => t.NoteDrop1000).HasColumnName("NoteDrop1000");
            this.Property(t => t.NoteRefill10).HasColumnName("NoteRefill10");
            this.Property(t => t.NoteRefill20).HasColumnName("NoteRefill20");
            this.Property(t => t.NoteRefill50).HasColumnName("NoteRefill50");
            this.Property(t => t.NoteRefill100).HasColumnName("NoteRefill100");
            this.Property(t => t.NoteRefill200).HasColumnName("NoteRefill200");
            this.Property(t => t.NoteRefill500).HasColumnName("NoteRefill500");
            this.Property(t => t.NoteRefill1000).HasColumnName("NoteRefill1000");
            this.Property(t => t.NoteOut10).HasColumnName("NoteOut10");
            this.Property(t => t.NoteOut20).HasColumnName("NoteOut20");
            this.Property(t => t.NoteOut50).HasColumnName("NoteOut50");
            this.Property(t => t.NoteOut100).HasColumnName("NoteOut100");
            this.Property(t => t.NoteOut200).HasColumnName("NoteOut200");
            this.Property(t => t.NoteOut500).HasColumnName("NoteOut500");
            this.Property(t => t.NoteOut1000).HasColumnName("NoteOut1000");
            this.Property(t => t.TotalBet).HasColumnName("TotalBet");
            this.Property(t => t.TotalWin).HasColumnName("TotalWin");
            this.Property(t => t.TotalCoinDrop).HasColumnName("TotalCoinDrop");
            this.Property(t => t.TotalBillDrop).HasColumnName("TotalBillDrop");
            this.Property(t => t.TotalGamesPlayed).HasColumnName("TotalGamesPlayed");
            this.Property(t => t.TotalGamesWon).HasColumnName("TotalGamesWon");
            this.Property(t => t.RemoteHandpayReset).HasColumnName("RemoteHandpayReset");
            this.Property(t => t.TotalHandPays).HasColumnName("TotalHandPays");
            this.Property(t => t.TotalCashIn).HasColumnName("TotalCashIn");
            this.Property(t => t.TotalCashOut).HasColumnName("TotalCashOut");
            this.Property(t => t.TotalCashlessIn).HasColumnName("TotalCashlessIn");
            this.Property(t => t.TotalCashlessOut).HasColumnName("TotalCashlessOut");
            this.Property(t => t.TotalJackpot).HasColumnName("TotalJackpot");
            this.Property(t => t.TotalTicketIn).HasColumnName("TotalTicketIn");
            this.Property(t => t.TotalTicketOut).HasColumnName("TotalTicketOut");
            this.Property(t => t.TotalDoorOpens).HasColumnName("TotalDoorOpens");
            this.Property(t => t.TotalCashDoorOpens).HasColumnName("TotalCashDoorOpens");
            this.Property(t => t.TotalLogicDoorOpens).HasColumnName("TotalLogicDoorOpens");
            this.Property(t => t.TotalCallAttendants).HasColumnName("TotalCallAttendants");
            this.Property(t => t.TransactionNumber).HasColumnName("TransactionNumber");
            this.Property(t => t.AccumulatedTotalBet).HasColumnName("AccumulatedTotalBet");
            this.Property(t => t.AccumulatedTotalWin).HasColumnName("AccumulatedTotalWin");
            this.Property(t => t.AccumulatedTotalCoinBoxDrop).HasColumnName("AccumulatedTotalCoinBoxDrop");
            this.Property(t => t.AccumulatedTotalBillDrop).HasColumnName("AccumulatedTotalBillDrop");
            this.Property(t => t.AccumulatedTotalGamesPlayed).HasColumnName("AccumulatedTotalGamesPlayed");
            this.Property(t => t.AccumulatedTotalHandPay).HasColumnName("AccumulatedTotalHandPay");
            this.Property(t => t.AccumulatedTotalCashIn).HasColumnName("AccumulatedTotalCashIn");
            this.Property(t => t.AccumulatedTotalCashOut).HasColumnName("AccumulatedTotalCashOut");
            this.Property(t => t.AccumulatedTotalCashlessIn).HasColumnName("AccumulatedTotalCashlessIn");
            this.Property(t => t.AccumulatedTotalCashlessOut).HasColumnName("AccumulatedTotalCashlessOut");
            this.Property(t => t.AccumulatedTotalTicketIn).HasColumnName("AccumulatedTotalTicketIn");
            this.Property(t => t.AccumulatedTotalTicketOut).HasColumnName("AccumulatedTotalTicketOut");
            this.Property(t => t.AccumulatedTotalJackpot).HasColumnName("AccumulatedTotalJackpot");
            this.Property(t => t.CollectionType).HasColumnName("CollectionType");
            this.Property(t => t.ActualCashCollected).HasColumnName("ActualCashCollected");
            this.Property(t => t.CalculatedCash).HasColumnName("CalculatedCash");
            this.Property(t => t.DateProcessed).HasColumnName("DateProcessed");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");
            this.Property(t => t.PortNumber).HasColumnName("PortNumber");
            this.Property(t => t.EPCCertifiedModelID).HasColumnName("EPCCertifiedModelID");
            this.Property(t => t.DateMigrated).HasColumnName("DateMigrated");
        }
    }
}
