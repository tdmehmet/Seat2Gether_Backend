using Seat2Gether.dto.MenuDto;
using Seat2Gether.Repositories;
using System;
using System.Collections.Generic;

namespace Seat2Gether.services
{

    public class MenuService
    {
        private MenuRepository MenuRepository = null;

        public MenuService()
        {
            MenuRepository = new MenuRepository();
        }

        public MainMenuItem GetUserMenu(string userName, String language)
        {
            
            List<Models.Menu> menuRoleList = MenuRepository.GetUserMenu(userName);
            if(menuRoleList.Count == 0)
            {
                return null;
            }
            List<Models.Menu> tmpMenuRoleList = new List<Models.Menu>();
            tmpMenuRoleList.AddRange(menuRoleList);
            MenuItem menuItem = CreateMainMenuItem(null, new List<MenuItem>(), tmpMenuRoleList, menuRoleList, language);
            MainMenuItem mainMenuItem = new MainMenuItem();
            mainMenuItem.path = menuItem.path;
            mainMenuItem.children = menuItem.children;
            return mainMenuItem;
        }

        private MenuItem CreateMainMenuItem(MenuItem mainMenuItem, List<MenuItem> menuItemList,List<Models.Menu> tmpMenuRoleList, List<Models.Menu> originalMenuRoleList, string language)
        {
            Models.Menu menu = tmpMenuRoleList.ToArray()[0];
            if(menu.Code.LastIndexOf(".") <= 0)
            {
                mainMenuItem = CreateMenuItemFromMenuRole(menuItemList, menu, language);
            }else { 

                MenuItem menuItem = CreateMenuItemFromMenuRole(menuItemList, menu, language);

                Models.Menu upperMenu = GetUpperMenuRole(menu.Code.Substring(0, menu.Code.LastIndexOf(".")), originalMenuRoleList);
                MenuItem upperMenuItem = CreateMenuItemFromMenuRole(menuItemList, upperMenu, language);
                upperMenuItem.children.Add(menuItem);


            }
            tmpMenuRoleList.Remove(menu);
            if (tmpMenuRoleList.Count == 0)
            {
                return mainMenuItem;
            }
            
            return CreateMainMenuItem(mainMenuItem, menuItemList, tmpMenuRoleList, originalMenuRoleList, language);
        }

        private Models.Menu GetUpperMenuRole(string upperMenuCode, List<Models.Menu> originalMenuRoleList)
        {
            foreach(Models.Menu tmpMenuRole in originalMenuRoleList)
            {
                if(tmpMenuRole.Code == upperMenuCode)
                {
                    return tmpMenuRole;
                }
            }
            
            throw new Exception("Menu could not be created");
        }

        private MenuItem CreateMenuItemFromMenuRole(List<MenuItem> menuItemList, Models.Menu menu, string language)
        {
            MenuItem menuItem = new MenuItem();
            menuItem.path = menu.Path;
            menuItem.data = new Data();
            menuItem.data.menu = new dto.MenuDto.Menu();
            menuItem.data.menu.icon = menu.Icon;
            menuItem.data.menu.expanded = menu.Expanded;
            menuItem.data.menu.order = menu.Order;
            if (language.ToUpper().Contains("TR"))
            {
                menuItem.data.menu.title = menu.TurkishName;
            }else if(language.ToUpper().Contains("DE"))
            {
                menuItem.data.menu.title = menu.GermanName;
            }else
            {
                menuItem.data.menu.title = menu.EnglishName;
            }
            menuItem.children = new List<MenuItem>();
            foreach(MenuItem tmpMenuItem in menuItemList) {
                if(tmpMenuItem.data.menu.title.Equals(menuItem.data.menu.title))
                {
                    return tmpMenuItem;
                }
            }
            menuItemList.Add(menuItem);
            return menuItem;
        }

        
    }
}