using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class RevenueProfileMap : EntityTypeConfiguration<RevenueProfile>
    {
        public RevenueProfileMap()
        {
            // Primary Key
            this.HasKey(t => t.RevenueProfileID);

            // Properties
            this.Property(t => t.RevenueProfileName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("RevenueProfiles");
            this.Property(t => t.RevenueProfileID).HasColumnName("RevenueProfileID");
            this.Property(t => t.RevenueProfileName).HasColumnName("RevenueProfileName");
            this.Property(t => t.OrganisationID).HasColumnName("OrganisationID");
            this.Property(t => t.DeductionTotalTypeID).HasColumnName("DeductionTotalTypeID");
            this.Property(t => t.AppliesOrganisationTypeID).HasColumnName("AppliesOrganisationTypeID");
            this.Property(t => t.CollectOrganisationTypeID).HasColumnName("CollectOrganisationTypeID");
            this.Property(t => t.RevenueProfileTypeID).HasColumnName("RevenueProfileTypeID");
            this.Property(t => t.DeductionTypeID).HasColumnName("DeductionTypeID");
            this.Property(t => t.CreditOrganisationTypeID).HasColumnName("CreditOrganisationTypeID");
            this.Property(t => t.IsSplit).HasColumnName("IsSplit");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.DateDeleted).HasColumnName("DateDeleted");

            // Relationships
            this.HasMany(t => t.OrganisationRevenuesSiteMachines)
                .WithMany(t => t.OrganisationRevenuesRevenueProfiles)
                .Map(m =>
                    {
                        m.ToTable("OrganisationRevenues");
                        m.MapLeftKey("RevenueProfileID");
                        m.MapRightKey("OrganisationID", "MachineID");
                    });

            this.HasOptional(t => t.DeductionTotalTypesDeductionTotalType)
                .WithMany(t => t.DeductionTotalTypesRevenueProfiles)
                .HasForeignKey(d => d.DeductionTotalTypeID);
            this.HasOptional(t => t.DeductionTypesDeductionType)
                .WithMany(t => t.DeductionTypesRevenueProfiles)
                .HasForeignKey(d => d.DeductionTypeID);
            this.HasRequired(t => t.OrganisationsOrganisation)
                .WithMany(t => t.OrganisationsRevenueProfiles)
                .HasForeignKey(d => d.OrganisationID);
            this.HasOptional(t => t.OrganisationTypesOrganisationType)
                .WithMany(t => t.OrganisationTypesRevenueProfiles)
                .HasForeignKey(d => d.AppliesOrganisationTypeID);
            this.HasOptional(t => t.OrganisationTypes1OrganisationType)
                .WithMany(t => t.OrganisationTypes1RevenueProfiles)
                .HasForeignKey(d => d.CollectOrganisationTypeID);
            this.HasOptional(t => t.OrganisationTypes2OrganisationType)
                .WithMany(t => t.OrganisationTypes2RevenueProfiles)
                .HasForeignKey(d => d.CreditOrganisationTypeID);
            this.HasOptional(t => t.RevenueProfileTypesRevenueProfileType)
                .WithMany(t => t.RevenueProfileTypesRevenueProfiles)
                .HasForeignKey(d => d.RevenueProfileTypeID);

        }
    }
}
