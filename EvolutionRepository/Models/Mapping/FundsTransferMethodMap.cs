using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class FundsTransferMethodMap : EntityTypeConfiguration<FundsTransferMethod>
    {
        public FundsTransferMethodMap()
        {
            // Primary Key
            this.HasKey(t => t.FundsTransferMethodID);

            // Properties
            this.Property(t => t.FundsTransferMethodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FundsTransferMethodName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FundsTransferMethods");
            this.Property(t => t.FundsTransferMethodID).HasColumnName("FundsTransferMethodID");
            this.Property(t => t.FundsTransferMethodName).HasColumnName("FundsTransferMethodName");
        }
    }
}
