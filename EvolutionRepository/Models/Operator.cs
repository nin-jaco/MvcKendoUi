using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Operator
    {
        public int OperatorID { get; set; }
        public Nullable<bool> IsRouteOperator { get; set; }
        public Nullable<bool> IsServiceProvider { get; set; }
        public Nullable<bool> IsSupplier { get; set; }
        public Nullable<bool> IsManufacturer { get; set; }
        public virtual Organisation OrganisationsOrganisation { get; set; }
    }
}
