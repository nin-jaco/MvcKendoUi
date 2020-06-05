using EvolutionDataAccess.Organisation;
using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.Organisations
{
    public class AreaLogic
    {
        public static EvolutionRepository.ManualModels.GetAreaListResult GetAllAreasForOrganisation(int organisationID, int skip, int take)
        {
            try
            {
                return AreaDAL.GetAllAreasForOrganisation(organisationID, skip, take);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static Area GetAreaByID(int areaID)
        {
            try
            {
                return AreaDAL.GetAreaByID(areaID);
            }
            catch (Exception ex)
            {
               throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static bool UpdateArea(Area updatedArea)
        {
            try
            {
                return AreaDAL.UpdateArea(updatedArea);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static bool AddArea(Area newArea)
        {
            try
            {
                return AreaDAL.AddArea(newArea);
            }
            catch (Exception ex)
            {
               throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static bool DeleteArea(int areaID)
        {
            try
            {
                return AreaDAL.DeleteArea(areaID);
            }
            catch (Exception ex)
            {
               throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }
    }
}
