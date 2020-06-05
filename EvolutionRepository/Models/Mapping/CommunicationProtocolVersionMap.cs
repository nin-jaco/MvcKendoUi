using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class CommunicationProtocolVersionMap : EntityTypeConfiguration<CommunicationProtocolVersion>
    {
        public CommunicationProtocolVersionMap()
        {
            // Primary Key
            this.HasKey(t => t.ProtocolVersionID);

            // Properties
            this.Property(t => t.ProtocolVersionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProtocolVersionName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommunicationProtocolVersions");
            this.Property(t => t.ProtocolVersionID).HasColumnName("ProtocolVersionID");
            this.Property(t => t.ProtocolVersionName).HasColumnName("ProtocolVersionName");
        }
    }
}
