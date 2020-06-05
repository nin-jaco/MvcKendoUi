using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class BankAccountTypeMap : EntityTypeConfiguration<BankAccountType>
    {
        public BankAccountTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BankID, t.AccountTypeID });

            // Properties
            this.Property(t => t.BankID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AccountTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BankAccountTypeCode)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("BankAccountTypes");
            this.Property(t => t.BankID).HasColumnName("BankID");
            this.Property(t => t.AccountTypeID).HasColumnName("AccountTypeID");
            this.Property(t => t.BankAccountTypeCode).HasColumnName("BankAccountTypeCode");

            // Relationships
            this.HasRequired(t => t.AccountTypesAccountType)
                .WithMany(t => t.AccountTypesBankAccountTypes)
                .HasForeignKey(d => d.AccountTypeID);
            this.HasRequired(t => t.BanksBank)
                .WithMany(t => t.BanksBankAccountTypes)
                .HasForeignKey(d => d.BankID);

        }
    }
}
