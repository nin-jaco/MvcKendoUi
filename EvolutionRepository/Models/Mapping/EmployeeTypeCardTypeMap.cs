using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class EmployeeTypeCardTypeMap : EntityTypeConfiguration<EmployeeTypeCardType>
    {
        public EmployeeTypeCardTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.JurisdictionID, t.EmployeeTypeID, t.CardTypeID });

            // Properties
            this.Property(t => t.JurisdictionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmployeeTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CardTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("EmployeeTypeCardTypes");
            this.Property(t => t.JurisdictionID).HasColumnName("JurisdictionID");
            this.Property(t => t.EmployeeTypeID).HasColumnName("EmployeeTypeID");
            this.Property(t => t.CardTypeID).HasColumnName("CardTypeID");
            this.Property(t => t.RequiredLicenseTypeID).HasColumnName("RequiredLicenseTypeID");

            // Relationships
            this.HasRequired(t => t.CardTypesCardType)
                .WithMany(t => t.CardTypesEmployeeTypeCardTypes)
                .HasForeignKey(d => d.CardTypeID);
            this.HasRequired(t => t.EmployeeTypesEmployeeType)
                .WithMany(t => t.EmployeeTypesEmployeeTypeCardTypes)
                .HasForeignKey(d => d.EmployeeTypeID);
            this.HasRequired(t => t.JurisdictionsJurisdiction)
                .WithMany(t => t.JurisdictionsEmployeeTypeCardTypes)
                .HasForeignKey(d => d.JurisdictionID);
            this.HasOptional(t => t.LicenseTypesLicenseType)
                .WithMany(t => t.LicenseTypesEmployeeTypeCardTypes)
                .HasForeignKey(d => d.RequiredLicenseTypeID);

        }
    }
}
