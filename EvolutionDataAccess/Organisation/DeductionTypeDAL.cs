using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionDataAccess.Organisation
{
    public class DeductionTypeDAL
    {
        public static List<DeductionType> GetAllDeductionTypes()
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                return ctx.DeductionTypes.ToList();
            }
        }
    }
}
