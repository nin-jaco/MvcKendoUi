using EvolutionDataAccess.Organisation;
using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.Organisations
{
    public class OrganisationCommTypeLogic
    {
        public static List<OrganisationCommType> GetAllOrganisationCommTypes()
        {
            try
            {
                return OrganisationCommTypeDAL.GetAllOrganisationCommTypes();
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

    }
}
