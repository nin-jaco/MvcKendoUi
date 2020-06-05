using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class OrganisationTypeMap : EntityTypeConfiguration<OrganisationType>
    {
        public OrganisationTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.OrganisationTypeID);

            // Properties
            this.Property(t => t.OrganisationTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrganisationTypeName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrganisationTypes");
            this.Property(t => t.OrganisationTypeID).HasColumnName("OrganisationTypeID");
            this.Property(t => t.OrganisationTypeName).HasColumnName("OrganisationTypeName");
            this.Property(t => t.IsLicensed).HasColumnName("IsLicensed");
            this.Property(t => t.IsBasedOnMachineRevenue).HasColumnName("IsBasedOnMachineRevenue");
            this.Property(t => t.HasSplits).HasColumnName("HasSplits");
            this.Property(t => t.HasRevenueProfiles).HasColumnName("HasRevenueProfiles");
            this.Property(t => t.HasFiscalPeriods).HasColumnName("HasFiscalPeriods");
            this.Property(t => t.HasAreas).HasColumnName("HasAreas");
            this.Property(t => t.HasDepartments).HasColumnName("HasDepartments");
            this.Property(t => t.HasContacts).HasColumnName("HasContacts");
            this.Property(t => t.HasBankAccounts).HasColumnName("HasBankAccounts");
            this.Property(t => t.HasActiveDailyPeriods).HasColumnName("HasActiveDailyPeriods");
            this.Property(t => t.HasCommunications).HasColumnName("HasCommunications");
            this.Property(t => t.HasLicenses).HasColumnName("HasLicenses");
            this.Property(t => t.HasLocations).HasColumnName("HasLocations");
            this.Property(t => t.HasEmployees).HasColumnName("HasEmployees");
            this.Property(t => t.HasMachines).HasColumnName("HasMachines");
            this.Property(t => t.ApprovesMachines).HasColumnName("ApprovesMachines");
            this.Property(t => t.ApprovesMovements).HasColumnName("ApprovesMovements");
            this.Property(t => t.RequestsMovements).HasColumnName("RequestsMovements");
            this.Property(t => t.HasInvoices).HasColumnName("HasInvoices");
            this.Property(t => t.HasLoans).HasColumnName("HasLoans");
        }
    }
}
