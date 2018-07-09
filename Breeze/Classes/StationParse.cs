using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Breeze.Classes
{
    class StationParse
    {
        public string Ip { get; set; }
        public string UserStationName { get; set; }
        public StationParse(String ip, String name)
        {
            this.Ip = ip;
            this.UserStationName = name;
        }
    }
}
