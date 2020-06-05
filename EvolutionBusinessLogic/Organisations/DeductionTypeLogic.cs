using EvolutionDataAccess.Organisation;
using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.Organisations
{
    public class DeductionTypeLogic
    {
        public static List<DeductionType> GetAllDeductionTypes()
        {
            return DeductionTypeDAL.GetAllDeductionTypes();
        }
    }
}
