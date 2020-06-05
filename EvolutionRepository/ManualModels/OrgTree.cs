using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvolutionRepository.ManualModels
{
    public class GetOrgTreeListResult
    {
        public List<EvolutionRepository.ManualModels.OrgTree> Data;
        public int Count; // Must contain the TOTAL number of records that the user can page through
    }
    public class OrgTree
    {
        public int OrganisationID { get; set; }
        public string OrganisationName { get; set; }
    }
}