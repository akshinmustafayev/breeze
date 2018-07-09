using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Breeze.Classes
{
    class FindStationByCategory
    {
        public string Ip { get; set; }
        public string UserStationName { get; set; }
        public FindStationByCategory(String ip, String name)
        {
            this.Ip = ip;
            this.UserStationName = name;
        }
    }
}
