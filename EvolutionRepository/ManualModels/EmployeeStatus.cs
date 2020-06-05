using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EvolutionRepository.ManualModels
{
    public class EmployeeStatusManualModel
    {
        [Key]
        public Int32 Id { get; set; }

        public String Description { get; set; }
    }
}
