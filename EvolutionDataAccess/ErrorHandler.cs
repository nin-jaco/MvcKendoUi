using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace EvolutionDataAccess
{
    public static class ErrorHandler
    {
        public static String BuildDbEntityValidationErrorMessage(DbEntityValidationException ex)
        {
            StringBuilder exceptionMessage = new StringBuilder();
            Boolean bFirstError = true;
            foreach (var validationErrors in ex.EntityValidationErrors)
            {
                exceptionMessage.Append("Error in ");
                exceptionMessage.Append(validationErrors.Entry.Entity.GetType().Name);
                exceptionMessage.Append(": ");
                foreach (var validationError in validationErrors.ValidationErrors)
                {
                    if (!bFirstError)
                    {
                        exceptionMessage.Append(", ");
                    }
                    exceptionMessage.Append(String.Format(validationError.ErrorMessage));
                    bFirstError = false;
                    //exceptionMessage.Append(String.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage));
                }
            }

            // Retrieve the error messages as a list of strings.
            //var errorMessages = ex.EntityValidationErrors
            //        .SelectMany(x => x.ValidationErrors)
            //        .Select(x => x.ErrorMessage);

            //// Join the list to a single string.
            //var fullErrorMessage = string.Join("; ", errorMessages);

            //// Combine the original exception message with the new one.
            //var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

            // Throw a new DbEntityValidationException with the improved exception message.
            return exceptionMessage.ToString();
        }
    }
}
