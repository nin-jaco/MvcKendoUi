using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EvolutionWeb.Controllers.api
{
    public class DeductionTypeController : ApiController
    {
        public IEnumerable<EvolutionRepository.Models.DeductionType> GetListOfDeductionTypes()
        {
            return EvolutionBusinessLogic.Organisations.DeductionTypeLogic.GetAllDeductionTypes();
        }
    }
}
