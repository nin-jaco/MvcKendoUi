using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionRepository.ManualModels
{
    public class SearchOrganisationsParams
    {
        public string parentorganisation { get; set; }
        public string organisation { get; set; }
        public string childto { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string jurisdiction { get; set; }
        public int pageSize { get; set; }
        public int page { get; set; }
        public int skip { get; set; }
        public int take { get; set; }
    }
}
