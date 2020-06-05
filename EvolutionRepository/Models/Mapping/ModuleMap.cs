using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ModuleMap : EntityTypeConfiguration<Module>
    {
        public ModuleMap()
        {
            // Primary Key
            this.HasKey(t => t.ModuleID);

            // Properties
            this.Property(t => t.ModuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ModuleName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Modules");
            this.Property(t => t.ModuleID).HasColumnName("ModuleID");
            this.Property(t => t.ModuleName).HasColumnName("ModuleName");
            this.Property(t => t.IsSystem).HasColumnName("IsSystem");

            // Relationships
            this.HasMany(t => t.OrganisationTypeModulesOrganisationTypes)
                .WithMany(t => t.OrganisationTypeModulesModules)
                .Map(m =>
                    {
                        m.ToTable("OrganisationTypeModules");
                        m.MapLeftKey("ModuleID");
                        m.MapRightKey("OrganisationTypeID");
                    });


        }
    }
}
