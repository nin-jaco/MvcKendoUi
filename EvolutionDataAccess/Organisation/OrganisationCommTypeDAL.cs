using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionDataAccess.Organisation
{
    public class OrganisationCommTypeDAL
    {
        public static List<OrganisationCommType> GetAllOrganisationCommTypes()
        {
            using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                return ctx.OrganisationCommTypes.AsNoTracking().ToList();
            }
        }
    }
}
