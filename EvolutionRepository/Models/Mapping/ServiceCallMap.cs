using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EvolutionRepository.Models.Mapping
{
    public class ServiceCallMap : EntityTypeConfiguration<ServiceCall>
    {
        public ServiceCallMap()
        {
            // Primary Key
            this.HasKey(t => t.ServiceCallID);

            // Properties
            this.Property(t => t.FaultDescription)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.Comments)
                .HasMaxLength(255);

            this.Property(t => t.JobCardNumber)
                .HasMaxLength(25);

            this.Property(t => t.TimeStamp)
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("ServiceCalls");
            this.Property(t => t.ServiceCallID).HasColumnName("ServiceCallID");
            this.Property(t => t.SiteID).HasColumnName("SiteID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.ReceivedByID).HasColumnName("ReceivedByID");
            this.Property(t => t.TargetEngineerID).HasColumnName("TargetEngineerID");
            this.Property(t => t.FixingEngineerID).HasColumnName("FixingEngineerID");
            this.Property(t => t.FaultDescription).HasColumnName("FaultDescription");
            this.Property(t => t.CallReceiptTime).HasColumnName("CallReceiptTime");
            this.Property(t => t.ArrivalTime).HasColumnName("ArrivalTime");
            this.Property(t => t.TimeCompleted).HasColumnName("TimeCompleted");
            this.Property(t => t.FaultID).HasColumnName("FaultID");
            this.Property(t => t.SignificantEventID).HasColumnName("SignificantEventID");
            this.Property(t => t.Comments).HasColumnName("Comments");
            this.Property(t => t.JobCardNumber).HasColumnName("JobCardNumber");
            this.Property(t => t.RepairStatusID).HasColumnName("RepairStatusID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");

            // Relationships
            this.HasRequired(t => t.RepairStatusesRepairStatus)
                .WithMany(t => t.RepairStatusesServiceCalls)
                .HasForeignKey(d => d.RepairStatusID);

        }
    }
}
