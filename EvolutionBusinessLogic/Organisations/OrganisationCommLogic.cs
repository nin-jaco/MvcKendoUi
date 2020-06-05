using EvolutionDataAccess.Organisation;
using EvolutionRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.Organisations
{
    public class OrganisationCommLogic
    {
        public static EvolutionRepository.ManualModels.GetOrganisationCommListResult GetAllOrganisationCommsByID(int organisationID, int skip, int take)
        {
            try
            {
                return OrganisationCommDAL.GetAllOrganisationCommsByID(organisationID, skip, take);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static OrganisationComm GetOrganisationCommByID(int ID)
        {
            try
            {
                return OrganisationCommDAL.GetOrganisationCommByID(ID);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static bool EditOrganisationComm(OrganisationComm organisationComm)
        {
            try
            {
                return OrganisationCommDAL.EditOrganisationComm(organisationComm);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static bool InsertOrganisationComm(OrganisationComm organisationComm)
        {
            try
            {
                return OrganisationCommDAL.InsertOrganisationComm(organisationComm);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }

        public static bool DeleteOrganisationComm(int organisationCommID)
        {
            try
            {
                return OrganisationCommDAL.DeleteOrganisationComm(organisationCommID);
            }
            catch (Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException(ex.Message, ex.InnerException);
            }
        }
    }
}
