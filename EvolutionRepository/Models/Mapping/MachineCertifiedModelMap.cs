using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class MachineCertifiedModelMap : EntityTypeConfiguration<MachineCertifiedModel>
    {
        public MachineCertifiedModelMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MachineID, t.CertifiedModelID });

            // Properties
            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CertifiedModelID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MachineCertifiedModel");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.CertifiedModelID).HasColumnName("CertifiedModelID");
        }
    }
}
