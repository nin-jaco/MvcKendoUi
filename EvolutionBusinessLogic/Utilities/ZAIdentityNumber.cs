using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionBusinessLogic.Utilities
{
    //Modified from http://planetdonovan.com/post/Validating-South-African-ID-Numbers.aspx

    public class ZAIdentityNumber
    {
        public static bool IsZAIdentityNumberValid(string identityNumber, DateTime dateOfBirth)
        {
            bool IsValid = false;

            try
            {
                if (identityNumber.Length == 13)
                {
                    var digits = new int[13];
                    for (int i = 0; i < 13; i++)
                    {
                        digits[i] = int.Parse(identityNumber.Substring(i, 1));
                    }
                    int control1 = digits.Where((v, i) => i % 2 == 0 && i < 12).Sum();
                    string second = string.Empty;
                    digits.Where((v, i) => i % 2 != 0 && i < 12).ToList().ForEach(v =>
                                                                     second += v.ToString());
                    var string2 = (int.Parse(second) * 2).ToString();
                    int control2 = 0;
                    for (int i = 0; i < string2.Length; i++)
                    {
                        control2 += int.Parse(string2.Substring(i, 1));
                    }
                    var control = (10 - ((control1 + control2) % 10)) % 10;
                    if (digits[12] == control)
                    {
                        string errorMessage = string.Empty;

                        if (dateOfBirth == DateTime.ParseExact(identityNumber.Substring(0, 6), "yyMMdd", null))
                        {
                            IsValid = true;
                        }
                        else
                        {
                            errorMessage = "ID number does not correspond with date of birth. ";
                        }

                        if (string.IsNullOrEmpty(errorMessage)==false)
                        {
                            throw new EvolutionBusinessLogic.Exceptions.EvolutionException(errorMessage);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new EvolutionBusinessLogic.Exceptions.EvolutionException("Could not validate ID Number: " + ex.Message);
            }

            return IsValid;
        }         
    }
}
