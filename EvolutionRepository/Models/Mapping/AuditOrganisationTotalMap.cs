using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AuditOrganisationTotalMap : EntityTypeConfiguration<AuditOrganisationTotal>
    {
        public AuditOrganisationTotalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AuditFiscalYearID, t.AuditFiscalPeriodID, t.AuditOrganisationID });

            // Properties
            this.Property(t => t.AuditFiscalYearID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditFiscalPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditOrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditOrganisationName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrganisationTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JurisdictionName)
                .HasMaxLength(50);

            this.Property(t => t.OrganisationSubTypeName)
                .HasMaxLength(50);

            this.Property(t => t.PostalAddress1)
                .HasMaxLength(50);

            this.Property(t => t.PostalAddress2)
                .HasMaxLength(50);

            this.Property(t => t.PostalSuburb)
                .HasMaxLength(50);

            this.Property(t => t.PostalCity)
                .HasMaxLength(50);

            this.Property(t => t.PostalJurisdiction)
                .HasMaxLength(50);

            this.Property(t => t.BankAccountHolder)
                .HasMaxLength(50);

            this.Property(t => t.BankAccountNumber)
                .HasMaxLength(25);

            this.Property(t => t.Bank)
                .HasMaxLength(50);

            this.Property(t => t.Branch)
                .HasMaxLength(50);

            this.Property(t => t.BranchCode)
                .HasMaxLength(50);

            this.Property(t => t.AccountTypeName)
                .HasMaxLength(50);

            this.Property(t => t.BankAccountTypeCode)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("AuditOrganisationTotals");
            this.Property(t => t.AuditFiscalYearID).HasColumnName("AuditFiscalYearID");
            this.Property(t => t.AuditFiscalPeriodID).HasColumnName("AuditFiscalPeriodID");
            this.Property(t => t.AuditOrganisationID).HasColumnName("AuditOrganisationID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.AuditOrganisationName).HasColumnName("AuditOrganisationName");
            this.Property(t => t.OrganisationTypeID).HasColumnName("OrganisationTypeID");
            this.Property(t => t.OrganisationTypeName).HasColumnName("OrganisationTypeName");
            this.Property(t => t.JurisdictionID).HasColumnName("JurisdictionID");
            this.Property(t => t.JurisdictionName).HasColumnName("JurisdictionName");
            this.Property(t => t.OrganisationSubTypeID).HasColumnName("OrganisationSubTypeID");
            this.Property(t => t.OrganisationSubTypeName).HasColumnName("OrganisationSubTypeName");
            this.Property(t => t.MaximumMachines).HasColumnName("MaximumMachines");
            this.Property(t => t.NoOfMachines).HasColumnName("NoOfMachines");
            this.Property(t => t.NoOfChildren).HasColumnName("NoOfChildren");
            this.Property(t => t.NoOfEmployees).HasColumnName("NoOfEmployees");
            this.Property(t => t.NoOfChildEmployees).HasColumnName("NoOfChildEmployees");
            this.Property(t => t.NoOfStockMachines).HasColumnName("NoOfStockMachines");
            this.Property(t => t.NoOfSites).HasColumnName("NoOfSites");
            this.Property(t => t.PostalAddress1).HasColumnName("PostalAddress1");
            this.Property(t => t.PostalAddress2).HasColumnName("PostalAddress2");
            this.Property(t => t.PostalSuburb).HasColumnName("PostalSuburb");
            this.Property(t => t.PostalCity).HasColumnName("PostalCity");
            this.Property(t => t.PostalJurisdiction).HasColumnName("PostalJurisdiction");
            this.Property(t => t.BankAccountID).HasColumnName("BankAccountID");
            this.Property(t => t.BankAccountHolder).HasColumnName("BankAccountHolder");
            this.Property(t => t.BankAccountNumber).HasColumnName("BankAccountNumber");
            this.Property(t => t.Bank).HasColumnName("Bank");
            this.Property(t => t.Branch).HasColumnName("Branch");
            this.Property(t => t.BranchCode).HasColumnName("BranchCode");
            this.Property(t => t.TotalCoinsIn).HasColumnName("TotalCoinsIn");
            this.Property(t => t.TotalCoinboxDrop).HasColumnName("TotalCoinboxDrop");
            this.Property(t => t.TotalCoinRefill).HasColumnName("TotalCoinRefill");
            this.Property(t => t.TotalCoinsOut).HasColumnName("TotalCoinsOut");
            this.Property(t => t.TotalCoinDump).HasColumnName("TotalCoinDump");
            this.Property(t => t.TotalNotesIn).HasColumnName("TotalNotesIn");
            this.Property(t => t.TotalCashIn).HasColumnName("TotalCashIn");
            this.Property(t => t.TotalCashOut).HasColumnName("TotalCashOut");
            this.Property(t => t.TotalCashlessIn).HasColumnName("TotalCashlessIn");
            this.Property(t => t.TotalCashlessOut).HasColumnName("TotalCashlessOut");
            this.Property(t => t.TotalBet).HasColumnName("TotalBet");
            this.Property(t => t.TotalWin).HasColumnName("TotalWin");
            this.Property(t => t.TotalGamesPlayed).HasColumnName("TotalGamesPlayed");
            this.Property(t => t.TotalResets).HasColumnName("TotalResets");
            this.Property(t => t.TotalHandPays).HasColumnName("TotalHandPays");
            this.Property(t => t.TotalDoorOpens).HasColumnName("TotalDoorOpens");
            this.Property(t => t.TotalCashDoorOpens).HasColumnName("TotalCashDoorOpens");
            this.Property(t => t.TotalLogicDoorOpens).HasColumnName("TotalLogicDoorOpens");
            this.Property(t => t.TotalCallAttendants).HasColumnName("TotalCallAttendants");
            this.Property(t => t.TotalProgressiveWin).HasColumnName("TotalProgressiveWin");
            this.Property(t => t.DoubleUpIn).HasColumnName("DoubleUpIn");
            this.Property(t => t.DoubleUpOut).HasColumnName("DoubleUpOut");
            this.Property(t => t.RemoteCashIn).HasColumnName("RemoteCashIn");
            this.Property(t => t.RemoteCashOut).HasColumnName("RemoteCashOut");
            this.Property(t => t.GrossGamingRevenue).HasColumnName("GrossGamingRevenue");
            this.Property(t => t.NettGamingRevenue).HasColumnName("NettGamingRevenue");
            this.Property(t => t.SiteShare).HasColumnName("SiteShare");
            this.Property(t => t.OrganisationIndex).HasColumnName("OrganisationIndex");
            this.Property(t => t.AccountTypeID).HasColumnName("AccountTypeID");
            this.Property(t => t.AccountTypeName).HasColumnName("AccountTypeName");
            this.Property(t => t.BankAccountTypeCode).HasColumnName("BankAccountTypeCode");

            // Relationships
            this.HasRequired(t => t.AuditFiscalPeriodsAuditFiscalPeriod)
                .WithMany(t => t.AuditFiscalPeriodsAuditOrganisationTotals)
                .HasForeignKey(d => new { d.AuditFiscalYearID, d.AuditFiscalPeriodID });

        }
    }
}
