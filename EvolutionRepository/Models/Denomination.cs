using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Denomination
    {
        public int DenominationID { get; set; }
        public string DenominationName { get; set; }
        public int DenominationTypeID { get; set; }
        public decimal UnitValue { get; set; }
        public virtual DenominationType DenominationTypesDenominationType { get; set; }
    }
}
