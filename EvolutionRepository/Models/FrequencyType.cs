using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class FrequencyType
    {
        public FrequencyType()
        {
            this.FrequencyTypeSiteDisabledPeriods = new List<SiteDisabledPeriod>();
        }

        public int FrequencyTypeID { get; set; }
        public string FrequencyName { get; set; }
        public virtual ICollection<SiteDisabledPeriod> FrequencyTypeSiteDisabledPeriods { get; set; }
    }
}
