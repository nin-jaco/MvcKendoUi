using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class SiteMap : EntityTypeConfiguration<Site>
    {
        public SiteMap()
        {
            // Primary Key
            this.HasKey(t => t.SiteID);

            // Properties
            this.Property(t => t.SiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LiquorLicense)
                .HasMaxLength(50);

            this.Property(t => t.TimeStamp)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.BusinessLicense)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Sites");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.ParentManagerID).HasColumnName("ParentManagerID");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.SignedByID).HasColumnName("SignedByID");
            this.Property(t => t.SignedByDate).HasColumnName("SignedByDate");
            this.Property(t => t.CashCollectionTime).HasColumnName("CashCollectionTime");
            this.Property(t => t.DefaultRevenueProfileID).HasColumnName("DefaultRevenueProfileID");
            this.Property(t => t.ParentCollectorID).HasColumnName("ParentCollectorID");
            this.Property(t => t.LiquorLicense).HasColumnName("LiquorLicense");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.DemographicID).HasColumnName("DemographicID");
            this.Property(t => t.CardVersionNumber).HasColumnName("CardVersionNumber");
            this.Property(t => t.BusinessLicense).HasColumnName("BusinessLicense");
            this.Property(t => t.PDI).HasColumnName("PDI");
            this.Property(t => t.PDAInvestigatorID).HasColumnName("PDAInvestigatorID");
            this.Property(t => t.PDAInspectorID).HasColumnName("PDAInspectorID");
            this.Property(t => t.SDLUI).HasColumnName("SDLUI");

            // Relationships
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithOptional(t => t.OrganisationsSite);

        }
    }
}
