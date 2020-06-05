using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class DenominationType
    {
        public DenominationType()
        {
            this.DenominationTypesDenominations = new List<Denomination>();
        }

        public int DenominationTypeID { get; set; }
        public string DenominationTypeName { get; set; }
        public virtual ICollection<Denomination> DenominationTypesDenominations { get; set; }
    }
}
