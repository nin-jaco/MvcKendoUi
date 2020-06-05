using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvolutionWeb.Code
{
    public class GlobalUtilities
    {
        public static string IsActive(string ItemA, string ItemB)
        {
            if (ItemA == null || ItemB == null)
            {
                return null;
            }

            if (ItemA.ToLower() == ItemB.ToLower())
            {
                return "active" ;
            }
            else
            {
                return "";
            }
        }

        public static string IsCurrent(string ItemA, string ItemB)
        {
            if (ItemA == null || ItemB == null)
            {
                return null;
            }

            if (ItemA.ToLower() == ItemB.ToLower())
            {
                return "current";
            }
            else
            {
                return "";
            }
        }
    }
}