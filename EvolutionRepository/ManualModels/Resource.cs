using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EvolutionRepository.ManualModels
{
    public class Resource
    {
        [Key]
        public Int32 ResourceID { get; set; }
        public String ResourceName { get; set; }
        public String DisplayName { get; set; }
        public String Controller { get; set; }
        public String Action { get; set; }
    }
}
