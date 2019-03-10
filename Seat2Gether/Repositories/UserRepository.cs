using log4net;
using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Seat2Gether.Repositories
{
    public class UserRepository
    {
        private Seat2GetherDBContext DBContext;

        public UserRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        /**
        * Finds user with the given userName
        **/
        public User FindUserByUserName(String userName)
        {
            var userNameQuery = from user in DBContext.Users
                                where user.UserName == userName
                                select user;
            
            User selectedUser = userNameQuery.FirstOrDefault<User>();
            return selectedUser;
        }

        public List<User> FindUsersByUserBody(User userBody)
        {
            var userNameQuery = from user in DBContext.Users
                                where user.UserName.StartsWith(userBody.UserName)
                                && user.PersonnelName.StartsWith(userBody.PersonnelName)
                                && user.PersonnelSurname.StartsWith(userBody.PersonnelSurname)
                                && user.Email.StartsWith(userBody.Email)
                                && user.PhoneNumber.StartsWith(userBody.PhoneNumber)
                                select user;

            List<User> users = userNameQuery.ToList();
            return users;
        }

        /**
        * Finds users which likes the given userName
        **/
        public List<User> FindUsersStartsWithUserName(String userName)
        {
            var userNameQuery = from user in DBContext.Users
                                where user.UserName.StartsWith(userName)
                                select user;

            List<User> userList = userNameQuery.ToList<User>();
            return userList;
        }


        public User FindUserById(String Id)
        {
            return DBContext.Users.Find(Id);
        }

        /**
       * finds all users
       **/
        public List<User> FindUsers()
        {
            var usersQuery = from user in DBContext.Users
                             select user;
            List<User> allUsers = usersQuery.ToList();
            return allUsers;
        }


        /**
        * Deletes user 
        **/
        public void DeleteUser(User user)
        {
            DBContext.Users.Remove(user);
            DBContext.SaveChanges();
        }

        /**
        * Add a new user 
        **/
        public void AddUser(User user)
        {
            DBContext.Users.Add(user);
            DBContext.SaveChanges();
        }

        /**
        * Updates roles of an existing user 
        **/
        public void UpdateUserRoles(List<UserRole> OldUserRoleList, List<UserRole> NewUserRoleList)
        {
            //DBContext.UserRole.RemoveRange(OldUserRoleList);
            DBContext.UserRole.AddRange(NewUserRoleList);
            //UserRoleList.ToList<IdentityUserRole>().CreateMappedList<IdentityUserRole, UserRole>()
            DBContext.SaveChanges();
        }
    }
}