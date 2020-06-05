using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class BankMap : EntityTypeConfiguration<Bank>
    {
        public BankMap()
        {
            // Primary Key
            this.HasKey(t => t.BankID);

            // Properties
            this.Property(t => t.BankName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Banks");
            this.Property(t => t.BankID).HasColumnName("BankID");
            this.Property(t => t.BankName).HasColumnName("BankName");
        }
    }
}
