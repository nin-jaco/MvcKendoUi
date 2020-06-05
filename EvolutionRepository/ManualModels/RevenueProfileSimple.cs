using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionRepository.ManualModels
{
    public class RevenueProfileSimple
    {
        public int RevenueProfileID { get; set; }
        public string RevenueProfileName { get; set; }
        public int DeductionTotalTypeID { get; set; }
        public string DeductionTotalTypeName { get; set; }
        public int AppliesOrganisationTypeID { get; set; }
        public string AppliesOrganisationTypeName { get; set; }
        public int CollectOrganisationTypeID { get; set; }
        public string CollectOrganisationTypeName { get; set; }
        public int RevenueProfileTypeID { get; set; }
        public string RevenueProfileTypeName { get; set; }
        public int DeductionTypeID { get; set; }
        public string DeductionTypeName { get; set; }
        public int CreditOrganisationTypeID { get; set; }
        public string CreditOrganisationTypeName { get; set; }
        public DateTime DateAdded { get; set; }
        public float SiteSplit { get; set; }
        public float OperatorSplit { get; set; }
        public int OrganisationID { get; set; }
    }
}
