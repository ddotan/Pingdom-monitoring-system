using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pingdom.ObjectModel
{
    public class PortCheck : Check
    {
        public string host_name { get; set; }
        public int port { get; set; }
        public PortCheck()
        {
            type = "PORT";
        }
    }

}
