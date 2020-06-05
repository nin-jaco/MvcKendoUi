using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class EntityType
    {
        public EntityType()
        {
            this.EntityTypesLicenseTypes = new List<LicenseType>();
        }

        public int EntityTypeID { get; set; }
        public string EntityTypeName { get; set; }
        public virtual ICollection<LicenseType> EntityTypesLicenseTypes { get; set; }
    }
}
