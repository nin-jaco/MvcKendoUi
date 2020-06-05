using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class RevenueProfileType
    {
        public RevenueProfileType()
        {
            this.RevenueProfileTypesRevenueProfiles = new List<RevenueProfile>();
        }

        public int RevenueProfileTypeID { get; set; }
        public string RevenueProfileTypeName { get; set; }
        public string TotalFunction { get; set; }
        public string TotalTableName { get; set; }
        public string TotalFieldName { get; set; }
        public virtual ICollection<RevenueProfile> RevenueProfileTypesRevenueProfiles { get; set; }
    }
}
