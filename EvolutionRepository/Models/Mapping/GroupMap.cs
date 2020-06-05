using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            // Primary Key
            this.HasKey(t => t.GroupID);

            // Properties
            this.Property(t => t.GroupName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Groups");
            this.Property(t => t.GroupID).HasColumnName("GroupID");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.isAdmin).HasColumnName("isAdmin");
            this.Property(t => t.JurisdictionID).HasColumnName("JurisdictionID");

            // Relationships
            this.HasMany(t => t.GroupResourceActionsResourceActions)
                .WithMany(t => t.GroupResourceActionsGroups)
                .Map(m =>
                    {
                        m.ToTable("GroupResourceActions");
                        m.MapLeftKey("GroupID");
                        m.MapRightKey("ResourceID", "ActionID");
                    });

            this.HasMany(t => t.UserGroupsUsers)
                .WithMany(t => t.UserGroupsGroups)
                .Map(m =>
                    {
                        m.ToTable("UserGroups");
                        m.MapLeftKey("GroupID");
                        m.MapRightKey("EmployeeID");
                    });

            this.HasRequired(t => t.JurisdictionsJurisdiction)
                .WithMany(t => t.JurisdictionsGroups)
                .HasForeignKey(d => d.JurisdictionID);

        }
    }
}
