using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class UserSessionMap : EntityTypeConfiguration<UserSession>
    {
        public UserSessionMap()
        {
            // Primary Key
            this.HasKey(t => t.SessionID);

            // Properties
            this.Property(t => t.SessionID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserSessions");
            this.Property(t => t.SessionID).HasColumnName("SessionID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.SessionStarted).HasColumnName("SessionStarted");
            this.Property(t => t.TopOrganisationID).HasColumnName("TopOrganisationID");
        }
    }
}
