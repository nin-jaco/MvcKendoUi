using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CardWriteResultMap : EntityTypeConfiguration<CardWriteResult>
    {
        public CardWriteResultMap()
        {
            // Primary Key
            this.HasKey(t => t.CardWriteResultID);

            // Properties
            this.Property(t => t.CardWriteResultID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardWriteResultName)
                .IsRequired()
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("CardWriteResults");
            this.Property(t => t.CardWriteResultID).HasColumnName("CardWriteResultID");
            this.Property(t => t.CardWriteResultName).HasColumnName("CardWriteResultName");
            this.Property(t => t.ForceCardDelete).HasColumnName("ForceCardDelete");
        }
    }
}
