using System.Collections.Generic;

namespace Seat2Gether.dto.MenuDto
{
    public class MainMenuItem
    {
        public string path { get; set; }
        public List<MenuItem> children { get; set; }
    }
}