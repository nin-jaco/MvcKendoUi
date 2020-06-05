using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvolutionRepository.ManualModels;
using EvolutionRepository.Models;

namespace EvolutionDataAccess.Account
{
    public class UserDAL
    {
        public static User CreateUser(RegisterModel registerUser)
        {
            User user = new User();

            //string Username, string password, string email

            return user;
        }

        public static User GetUser(string Username)
        {
            User user = new User();
            try
            {
                using (var ctx = new EvolutionRepository.Models.EvolutionDBContext())
                {
                    user = ctx.Users.FirstOrDefault(x => x.UserName == Username);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user;
        }

        public static User UpdateUser(User user)
        {

            return user;
        }

        public static User ChangePassword(string Username, string newPassword)
        {
            User user = new User();

            return user;
        }

        public static User ResetPassword(string Username)
        {
            User user = new User();

            return user;
        }

        public static User DeleteUser(string Username, bool deleteAllRelatedData)
        {
            User user = new User();

            return user;
        }

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            return users;
        }

        public static List<User> GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            List<User> users = new List<User>();
            totalRecords = 0;

            return users;
        }

        public static List<User> FindUsersByEmail(string email, int pageIndex, int pageSize, out int totalRecords)
        {
            List<User> users = new List<User>();

            totalRecords = 0;

            return users;
        }

        public static List<User> FindUsersByUsername(string Username, int pageIndex, int pageSize, out int totalRecords)
        {
            List<User> users = new List<User>();

            totalRecords = 0;

            return users;
        }

    }
}
