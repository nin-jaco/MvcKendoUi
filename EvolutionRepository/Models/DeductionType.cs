using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class DeductionType
    {
        public DeductionType()
        {
            this.DeductionTypesRevenueProfiles = new List<RevenueProfile>();
        }

        public int DeductionTypeID { get; set; }
        public string DeductionTypeName { get; set; }
        public virtual ICollection<RevenueProfile> DeductionTypesRevenueProfiles { get; set; }
    }
}
