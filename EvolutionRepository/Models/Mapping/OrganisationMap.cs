using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationMap : EntityTypeConfiguration<Organisation>
    {
        public OrganisationMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganisationID);

            // Properties
            this.Property(t => t.OrganisationName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompanyNumber)
                .HasMaxLength(255);

            this.Property(t => t.TaxNumber)
                .HasMaxLength(255);

            this.Property(t => t.TelephoneCode)
                .HasMaxLength(50);

            this.Property(t => t.TelephoneNumber)
                .HasMaxLength(50);

            this.Property(t => t.FaxCode)
                .HasMaxLength(50);

            this.Property(t => t.FaxNumber)
                .HasMaxLength(50);

            this.Property(t => t.ContactName)
                .HasMaxLength(50);

            this.Property(t => t.EmailAddress)
                .HasMaxLength(50);

            this.Property(t => t.WebSiteURL)
                .HasMaxLength(50);

            this.Property(t => t.Timestamp)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("Organisations");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.OrganisationName).HasColumnName("OrganisationName");
            this.Property(t => t.CompanyNumber).HasColumnName("CompanyNumber");
            this.Property(t => t.TaxNumber).HasColumnName("TaxNumber");
            this.Property(t => t.OrganisationTypeID).HasColumnName("OrganisationTypeID");
            this.Property(t => t.OrganisationSubTypeID).HasColumnName("OrganisationSubTypeID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.MaximumMachines).HasColumnName("MaximumMachines");
            this.Property(t => t.JurisdictionID).HasColumnName("JurisdictionID");
            this.Property(t => t.TelephoneCode).HasColumnName("TelephoneCode");
            this.Property(t => t.TelephoneNumber).HasColumnName("TelephoneNumber");
            this.Property(t => t.FaxCode).HasColumnName("FaxCode");
            this.Property(t => t.FaxNumber).HasColumnName("FaxNumber");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.EmailAddress).HasColumnName("EmailAddress");
            this.Property(t => t.WebSiteURL).HasColumnName("WebSiteURL");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.BankAccountID).HasColumnName("BankAccountID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.DateDeleted).HasColumnName("DateDeleted");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.OrganisationStatusID).HasColumnName("OrganisationStatusID");

            // Relationships
            this.HasOptional(t => t.BankAccountsBankAccount)
                .WithMany(t => t.BankAccountsOrganisations)
                .HasForeignKey(d => d.BankAccountID);
            this.HasOptional(t => t.JurisdictionsJurisdiction)
                .WithMany(t => t.JurisdictionsOrganisations)
                .HasForeignKey(d => d.JurisdictionID);
            this.HasRequired(t => t.OrganisationTypesOrganisationType)
                .WithMany(t => t.OrganisationTypesOrganisations)
                .HasForeignKey(d => d.OrganisationTypeID);

        }
    }
}
