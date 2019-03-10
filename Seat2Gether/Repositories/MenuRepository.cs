using Microsoft.AspNet.Identity.EntityFramework;
using Seat2Gether.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Seat2Gether.Repositories
{
    public class MenuRepository
    {
        private Seat2GetherDBContext DBContext;

        public MenuRepository()
        {
            DBContext = new Seat2GetherDBContext();
        }

        /**
        * Gets all menu items with correspondent userName
        **/
        public List<Menu> GetUserMenu(string userName)
        {



            List<Menu> menuList =   (from menu in DBContext.Menus
                            join rolemenu in DBContext.RoleMenu on menu.Id equals rolemenu.MenuId
                            join role in DBContext.Roles on rolemenu.RoleId equals role.Id
                            join userRole in DBContext.UserRole on role.Id equals userRole.RoleId
                            join user in DBContext.Users on userRole.UserId equals user.Id 
                            where user.UserName == userName
                            orderby menu.Code
                            select menu).ToList();
            List<Menu> returnMenuList = new List<Menu>();
            foreach(Menu menu in menuList)
            {
                if (!returnMenuList.Contains(menu))
                {
                    returnMenuList.Add(menu);
                }
            }
            return returnMenuList;
        }

    }
}