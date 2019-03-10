
using log4net;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Seat2Gether.dto;
using Seat2Gether.Exceptions;
using Seat2Gether.Models;
using Seat2Gether.Repositories;
using Seat2Gether.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Validation;

namespace Seat2Gether.services
{

    public class UserService
    {
        private Seat2GetherDBContext DBContext;
        private UserRepository UserRepository = null;
        private UserManager<IdentityUser> UserManager;

        public UserService()
        {
            DBContext = new Seat2GetherDBContext();
            UserRepository = new UserRepository();
            UserManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(DBContext));
        }

        public UserDto FindUserByUserName(string userName)
        {
            
            UserDto userDto = new UserDto();
            User user = UserRepository.FindUserByUserName(userName);

            userDto = user.CreateMapped<User, UserDto>();
            return userDto;
        }

        /**
        * Finds users which likes the given userName
        **/
        public List<UserDto> FindUsersStartsWithUserName(String userName)
        {
            List<UserDto> usersDto = new List<UserDto>();
            List<User> users = UserRepository.FindUsersStartsWithUserName(userName);

            usersDto = users.CreateMappedList<User, UserDto>();
            return usersDto;
        }

        public List<UserDto> FindUsers()
        {

            List<UserDto> usersDto = new List<UserDto>();
            List<User> users = UserRepository.FindUsers();

            usersDto = users.CreateMappedList<User, UserDto>();
            return usersDto;
        }

        public List<UserDto> FindUsersByUserBody(UserDto userDto)
        {

            User userBody = userDto.CreateMapped<UserDto, User>();
            List<User> users = UserRepository.FindUsersByUserBody(userBody);

            List<UserDto> usersDto = users.CreateMappedList<User, UserDto>();
            return usersDto;
        }


        public User FindUserById(String Id)
        {
            return UserRepository.FindUserById(Id);
        }

        public void DeleteUser(User user)
        {
            User tmpUser = UserRepository.FindUserByUserName(user.UserName);
            UserRepository.DeleteUser(tmpUser);
        }

        
        public void AddUser(User user)
        {
            User tmpUser = UserRepository.FindUserByUserName(user.UserName);
            if (tmpUser == null)
            {
                user.DateCreated = DateTime.Now;
                UserRepository.AddUser(user);
            }
        }
        
        public void AddUserWithRoles(UserDto userModel)
        {
            User tmpUser = null;
            try
            {
                tmpUser = UserRepository.FindUserByUserName(userModel.UserName);
            }catch(Exception e)
            {
                //Do not handle this exception just to know if user exists or not
            }
            User user = null;
            if (tmpUser == null)
            {
                user = new User();
                user.UserName = userModel.UserName;
                user.DateCreated = DateTime.Now;
                user.Activated = true;
                user.Email = userModel.Email;
                user.PhoneNumber = userModel.PhoneNumber;
                user.PersonnelName = userModel.PersonnelName.ToString();
                user.PersonnelSurname = userModel.PersonnelSurname.ToString();
                user.Password = Constraints.DefaultDBPassword;
                user.ConfirmPassword = Constraints.DefaultDBPassword;
                UserRepository.AddUser(user);                       
            }
            else
            {
                user = tmpUser;
            }
            List<UserRole> oldUserRoleList = user.Roles.ToList<IdentityUserRole>().CreateMappedList<IdentityUserRole, UserRole>();
            List<UserRole> newUserRoleList = new List<UserRole>();
            user.Roles.Clear();
            if (userModel.Roles != null && userModel.Roles.Count > 0)
            {
                foreach (IdentityUserRole userRole in userModel.Roles)
                {
                    UserRole tmpUserRole = new UserRole();
                    tmpUserRole.UserId = user.Id;
                    tmpUserRole.RoleId = userRole.RoleId;
                    newUserRoleList.Add(tmpUserRole);
                }
            }
            oldUserRoleList.ToList<IdentityUserRole>();
            UserRepository.UpdateUserRoles(oldUserRoleList, newUserRoleList);
        }
    }
}