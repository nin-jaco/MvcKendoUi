using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class BankAccountMap : EntityTypeConfiguration<BankAccount>
    {
        public BankAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganisationID);

            // Properties
            this.Property(t => t.OrganisationID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AccountHolder)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AccountNumber)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Branch)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BranchCode)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("BankAccounts");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.AccountHolder).HasColumnName("AccountHolder");
            this.Property(t => t.AccountNumber).HasColumnName("AccountNumber");
            this.Property(t => t.BankID).HasColumnName("BankID");
            this.Property(t => t.Branch).HasColumnName("Branch");
            this.Property(t => t.BranchCode).HasColumnName("BranchCode");
            this.Property(t => t.AccountTypeID).HasColumnName("AccountTypeID");

            // Relationships
            this.HasOptional(t => t.AccountTypesAccountType)
                .WithMany(t => t.AccountTypesBankAccounts)
                .HasForeignKey(d => d.AccountTypeID);
            this.HasRequired(t => t.BanksBank)
                .WithMany(t => t.BanksBankAccounts)
                .HasForeignKey(d => d.BankID);

        }
    }
}
