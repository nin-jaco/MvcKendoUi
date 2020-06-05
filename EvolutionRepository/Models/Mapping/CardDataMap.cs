using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CardDataMap : EntityTypeConfiguration<CardData>
    {
        public CardDataMap()
        {
            // Primary Key
            this.HasKey(t => t.CardDataID);

            // Properties
            this.Property(t => t.PINCode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.Comments)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("CardData");
            this.Property(t => t.CardDataID).HasColumnName("CardDataID");
            this.Property(t => t.CardID).HasColumnName("CardID");
            this.Property(t => t.CardActionID).HasColumnName("CardActionID");
            this.Property(t => t.ExpiryDate).HasColumnName("ExpiryDate");
            this.Property(t => t.PINCode).HasColumnName("PINCode");
            this.Property(t => t.PINUpdateID).HasColumnName("PINUpdateID");
            this.Property(t => t.InstructionID).HasColumnName("InstructionID");
            this.Property(t => t.AvailableForIssue).HasColumnName("AvailableForIssue");
            this.Property(t => t.AvailableForUpdate).HasColumnName("AvailableForUpdate");
            this.Property(t => t.CardWriteResultID).HasColumnName("CardWriteResultID");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.LastUpdatedByEmployeeID).HasColumnName("LastUpdatedByEmployeeID");

            // Relationships
            this.HasRequired(t => t.CardActionsCardAction)
                .WithMany(t => t.CardActionsCardData)
                .HasForeignKey(d => d.CardActionID);
            this.HasRequired(t => t.CardsCard)
                .WithMany(t => t.CardsCardData)
                .HasForeignKey(d => d.CardID);
            this.HasOptional(t => t.CardWriteResultsCardWriteResult)
                .WithMany(t => t.CardWriteResultsCardData)
                .HasForeignKey(d => d.CardWriteResultID);
            this.HasRequired(t => t.Employees1Employee)
                .WithMany(t => t.Employees1CardData)
                .HasForeignKey(d => d.LastUpdatedByEmployeeID);
            this.HasOptional(t => t.InstructionsInstruction)
                .WithMany(t => t.InstructionsCardData)
                .HasForeignKey(d => d.InstructionID);
            this.HasRequired(t => t.PINUpdatesPINUpdate)
                .WithMany(t => t.PINUpdatesCardData)
                .HasForeignKey(d => d.PINUpdateID);

        }
    }
}
