using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvolutionRepository.ManualModels
{
    public class Title
    {
        [Key]
        public Int32 Id { get; set; }

        public String Desciption { get; set; }
    }
}