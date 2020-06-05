using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class LoanMap : EntityTypeConfiguration<Loan>
    {
        public LoanMap()
        {
            // Primary Key
            this.HasKey(t => t.LoanID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Loans");
            this.Property(t => t.LoanID).HasColumnName("LoanID");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.BorrowerOrganisationID).HasColumnName("BorrowerOrganisationID");
            this.Property(t => t.StartFiscalYearID).HasColumnName("StartFiscalYearID");
            this.Property(t => t.StartFiscalPeriodID).HasColumnName("StartFiscalPeriodID");
            this.Property(t => t.TotalLoanAmount).HasColumnName("TotalLoanAmount");
            this.Property(t => t.TotalRepaymentAmount).HasColumnName("TotalRepaymentAmount");
            this.Property(t => t.LoanBalance).HasColumnName("LoanBalance");
            this.Property(t => t.PeriodRepaymentAmount).HasColumnName("PeriodRepaymentAmount");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.SettlementDate).HasColumnName("SettlementDate");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");

            // Relationships
            this.HasRequired(t => t.RevenueProfilesRevenueProfile)
                .WithMany(t => t.RevenueProfilesLoans)
                .HasForeignKey(d => d.RevenueProfileID);

        }
    }
}
