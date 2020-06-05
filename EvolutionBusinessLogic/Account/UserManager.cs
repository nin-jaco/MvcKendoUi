using System;
using System.Collections.Generic;
using EvolutionDataAccess.Account;
using EvolutionRepository.ManualModels;
using EvolutionRepository.Models;

namespace EvolutionBusinessLogic.Account
{
    public class UserManager
    {
        public static string CreateUser(RegisterModel registerUser)
        {
            string CreatStatus = null;

            User user = UserDAL.CreateUser(registerUser);

            //set CreatStatus

            switch ((Enumeration.CreateUserStatus)Enum.Parse(typeof(Enumeration.CreateUserStatus), CreatStatus))
            {
                case Enumeration.CreateUserStatus.Successful:
                    return "Successful";

                case Enumeration.CreateUserStatus.DuplicateUsername:
                    return "User name already exists. Please enter a different user name.";

                case Enumeration.CreateUserStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case Enumeration.CreateUserStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case Enumeration.CreateUserStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case Enumeration.CreateUserStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case Enumeration.CreateUserStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case Enumeration.CreateUserStatus.InvalidUsername:
                    return "The user name provided is invalid. Please check the value and try again.";

                case Enumeration.CreateUserStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case Enumeration.CreateUserStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }

        //public static void UpdateUser(User updatedUser)
        //{
        //    User user = UserDAL.GetUser(updatedUser.UserName);

        //    user.Comment = updatedUser.Comment;
        //    user.Email = updatedUser.Email;
        //    user.IsApproved = updatedUser.IsApproved;

        //    UserDAL.UpdateUser(user);
        //}

        public static void UpdateUserPassword(string Username, string newPassword)
        {
            User user = UserDAL.GetUser(Username);

            UserDAL.ChangePassword(Username, newPassword);
        }

        public static void ResetUserPassword(string Username)
        {
            User user = UserDAL.GetUser(Username);

            UserDAL.ResetPassword(Username);

            //Email or SMS
        }

        public static void DeleteUser(string Username)
        {
            UserDAL.DeleteUser(Username, deleteAllRelatedData: true);
        }

        public static User LoadUserByUsername(string Username)
        {
            User user = UserDAL.GetUser(Username);

            return user;
        }

        public static ICollection<User> LoadAllUsers()
        {
            ICollection<User> users = UserDAL.GetAllUsers();

            return users;
        }

        public static ICollection<User> LoadAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            ICollection<User> users = UserDAL.GetAllUsers(pageIndex, pageSize, out totalRecords);

            return users;
        }

        public static ICollection<User> FindUsersByEmail(string email, int pageIndex, int pageSize, out int totalRecords)
        {
            ICollection<User> users = UserDAL.FindUsersByEmail(email, pageIndex, pageSize, out totalRecords);

            return users;
        }

        public static ICollection<User> FindUsersByUsername(string Username, int pageIndex, int pageSize, out int totalRecords)
        {
            ICollection<User> users = UserDAL.FindUsersByUsername(Username, pageIndex, pageSize, out totalRecords);

            return users;
        }
    }
}
