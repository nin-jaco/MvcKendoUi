using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.Exceptions
{
    public class EvolutionException : _ErrorException
    {
        public string DetailMessage { get; set; }

        public EvolutionException(string errorMessage) : base(errorMessage) { }

        public EvolutionException(string errorMessage, Exception innerEx) : base(errorMessage, innerEx) { }

        public EvolutionException(string errorMessage, string detailMessage) : base(errorMessage) 
        {
            this.DetailMessage = detailMessage;
        }

        public EvolutionException(string errorMessage, string detailMessage, Exception innerEx)
            : base(errorMessage, innerEx) 
        {
            this.DetailMessage = detailMessage;
        }
    }

    [Serializable]
    public class _ErrorException : Exception
    {
        public string ErrorMessage
        {
            get
            {
                return base.Message.ToString();
            }
        }

        public _ErrorException(string errorMessage)
            : base(errorMessage) { }

        public _ErrorException(string errorMessage, Exception innerEx)
            : base(errorMessage, innerEx) { }
    }

}
