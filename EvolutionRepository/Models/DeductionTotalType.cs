using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class DeductionTotalType
    {
        public DeductionTotalType()
        {
            this.DeductionTotalTypesRevenueProfiles = new List<RevenueProfile>();
        }

        public int DeductionTotalTypeID { get; set; }
        public string DeductionTotalTypeName { get; set; }
        public virtual ICollection<RevenueProfile> DeductionTotalTypesRevenueProfiles { get; set; }
    }
}
