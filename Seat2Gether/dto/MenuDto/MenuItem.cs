using System.Collections.Generic;

namespace Seat2Gether.dto.MenuDto
{
    public class MenuItem
    {
        /*
         path: '',
        data: {
          menu: {
            title: 'general.menu.external_link',
            url: 'http://akveo.com',
            icon: 'ion-android-exit',
            order: 800,
            target: '_blank'
          }
        */
        public string path { get; set; }
        public Data data { get; set; }
        public List<MenuItem> children { get; set; }
    }
}