using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class PhotoEmployee
    {
        public int PhotoID { get; set; }
        public int PhotoTypeID { get; set; }
        public int EmployeeID { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public byte[] upsize_ts { get; set; }
        public virtual Employee EmployeesEmployee { get; set; }
    }
}
