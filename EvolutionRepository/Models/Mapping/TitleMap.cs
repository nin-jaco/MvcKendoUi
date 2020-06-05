using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class TitleMap : EntityTypeConfiguration<Title>
    {
        public TitleMap()
        {
            // Primary Key
            this.HasKey(t => t.TitleID);

            // Properties
            this.Property(t => t.TitleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TitleName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Titles");
            this.Property(t => t.TitleID).HasColumnName("TitleID");
            this.Property(t => t.TitleName).HasColumnName("TitleName");
        }
    }
}
