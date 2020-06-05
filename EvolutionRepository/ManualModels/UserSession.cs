using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EvolutionRepository.ManualModels
{
    public class UserSession
    {
        [Key]
        public String SessionID { get; set; }
        public String UserName { get; set; }
    }
}
