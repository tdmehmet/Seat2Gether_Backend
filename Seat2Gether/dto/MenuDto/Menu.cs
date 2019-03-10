using System;

namespace Seat2Gether.dto.MenuDto
{
    public class Menu
    {
        /*title: 'general.menu.bant1tepsi1', // menu title
        icon: 'ion-android-home', // menu icon
        pathMatch: 'prefix', // use it if item children not displayed in menu
        selected: false,
        expanded: false,
        order: 0
        target: '_blank'
        */

        public string title { get; set; }
        public string icon { get; set; }
        public string prefix { get; set; }
        public Boolean selected { get; set; }
        public Boolean expanded { get; set; }
        public string order { get; set; }

    }
}