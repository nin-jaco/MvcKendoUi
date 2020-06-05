using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CommunicationProtocolMap : EntityTypeConfiguration<CommunicationProtocol>
    {
        public CommunicationProtocolMap()
        {
            // Primary Key
            this.HasKey(t => t.ProtocolID);

            // Properties
            this.Property(t => t.ProtocolID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProtocolName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommunicationProtocol");
            this.Property(t => t.ProtocolID).HasColumnName("ProtocolID");
            this.Property(t => t.ProtocolName).HasColumnName("ProtocolName");
            this.Property(t => t.ProtocolVersionID).HasColumnName("ProtocolVersionID");

            // Relationships
            this.HasRequired(t => t.CommunicationProtocolVersionsCommunicationProtocolVersion)
                .WithMany(t => t.CommunicationProtocolVersionsCommunicationProtocol)
                .HasForeignKey(d => d.ProtocolVersionID);

        }
    }
}
