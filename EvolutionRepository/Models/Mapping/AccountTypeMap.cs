using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class AccountTypeMap : EntityTypeConfiguration<AccountType>
    {
        public AccountTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountTypeID);

            // Properties
            this.Property(t => t.AccountTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AccountTypes");
            this.Property(t => t.AccountTypeID).HasColumnName("AccountTypeID");
            this.Property(t => t.AccountTypeName).HasColumnName("AccountTypeName");
        }
    }
}
