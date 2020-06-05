using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionRepository.ManualModels;
using EvolutionRepository.Models;

namespace EvolutionBusinessLogic.Authentication
{
    public class Authenticate
    {
        public static string ValidateUser(LogOnModel model)
        {
            string sessionID = String.Empty;
            try
            {
                // Get User details
                User user = EvolutionDataAccess.Account.UserDAL.GetUser(model.Username);
                if (!Object.Equals(user, null))
                {
                    if (!user.AccessRightsGranted)
                    {
                        throw new Exception("You do not have access rights to the CEMS or your access right have been revoked");
                    }
                    if (user.ForcePasswordChange)
                    {
                        throw new Exception("Your password needs to be changed");
                    }
                    // Validate password
                    RouteGaming.Encryption.RGSEncrypt encryptionObject = new RouteGaming.Encryption.RGSEncrypt();
                    encryptionObject.SetKey(model.Username);
                    if (encryptionObject.Encrypt(model.Password, true) == user.Password)
                    {
                        try
                        {
                            // Create Session and return SessionID
                            EvolutionRepository.ManualModels.UserSession userSession = new EvolutionRepository.ManualModels.UserSession();
                            userSession.SessionID = Guid.NewGuid().ToString();
                            userSession.UserName = model.Username;
                            EvolutionDataAccess.UserSession.UserSessionDAL.CreateUserSession(userSession);
                            sessionID = userSession.SessionID;
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error creating UserSession: " + ex.Message);
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid Password, try again");
                    }
                    // Check Password Life and other parameters
                }
                else
                {
                    throw new Exception("Invalid User Name");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return sessionID;
        }

        public static bool RegisterUser(RegisterModel model)
        {
            string CreatStatus = EvolutionBusinessLogic.Account.UserManager.CreateUser(model);

            return true;
        }

        public static bool ChangePassword(ChangePasswordModel model)
        {
            return true;
        }
    }
}
