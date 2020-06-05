using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class LoanRepaymentMap : EntityTypeConfiguration<LoanRepayment>
    {
        public LoanRepaymentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LoanID, t.DateOfPayment });

            // Properties
            this.Property(t => t.LoanID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comments)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("LoanRepayments");
            this.Property(t => t.LoanID).HasColumnName("LoanID");
            this.Property(t => t.DateOfPayment).HasColumnName("DateOfPayment");
            this.Property(t => t.AmountPaid).HasColumnName("AmountPaid");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.Comments).HasColumnName("Comments");

            // Relationships
            this.HasRequired(t => t.LoansLoan)
                .WithMany(t => t.LoansLoanRepayments)
                .HasForeignKey(d => d.LoanID);

        }
    }
}
