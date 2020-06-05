using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.Utilities
{
    public class BasicUtils
    {
        public static bool IsNumber(string word)
        {
            int result;

            return int.TryParse(word, out result);
        }

        public static DateTime? DateParser(string DateToParse, DateTime? Default)
        {
            DateTime validatedDate;
            bool dateValid;

            dateValid = DateTime.TryParse(DateToParse, out validatedDate);

            if (dateValid)
            {
                return validatedDate;
            }
            else
            {
                return Default;
            }
        }

        public static bool isDate(string DateToParse)
        {
            DateTime validatedDate;
            bool dateValid;

            dateValid = DateTime.TryParse(DateToParse, out validatedDate);

            if (dateValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string FormatDate(DateTime date)
        {
            var yyyy = date.Year.ToString();
            var mm = (date.Month).ToString(); // getMonth() is zero-based
            var dd = date.Day.ToString();

            return dd.PadLeft(2, '0') + ' ' + GetMonthName(Convert.ToInt32(mm)) + ' ' + yyyy; // padding
        }

        private static string GetMonthName(Int32 monthID)
        {
            string monthName = "";

            switch (monthID)
            {
                case 1:
                    monthName = "Jan";
                    break;

                case 2:
                    monthName = "Feb";
                    break;

                case 3:
                    monthName = "Mar";
                    break;

                case 4:
                    monthName = "Apr";
                    break;

                case 5:
                    monthName = "May";
                    break;

                case 6:
                    monthName = "Jun";
                    break;

                case 7:
                    monthName = "Jul";
                    break;

                case 8:
                    monthName = "Aug";
                    break;

                case 9:
                    monthName = "Sep";
                    break;

                case 10:
                    monthName = "Oct";
                    break;

                case 11:
                    monthName = "Nov";
                    break;

                case 12:
                    monthName = "Dec";
                    break;

                default:
                    monthName = "";
                    break;
            }

            return monthName;
        }

    }
}
