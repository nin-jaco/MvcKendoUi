using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class Title
    {
        public Title()
        {
            this.TitlesEmployees = new List<Employee>();
        }

        public int TitleID { get; set; }
        public string TitleName { get; set; }
        public virtual ICollection<Employee> TitlesEmployees { get; set; }
    }
}
