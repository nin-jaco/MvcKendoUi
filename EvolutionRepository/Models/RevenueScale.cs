using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class RevenueScale
    {
        public int RevenueProfileID { get; set; }
        public int RevenueScaleID { get; set; }
        public Nullable<decimal> FixedAmount { get; set; }
        public double Limit { get; set; }
        public float Rate { get; set; }
        public System.DateTime DateAdded { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
        public virtual RevenueProfile RevenueProfilesRevenueProfile { get; set; }
    }
}
