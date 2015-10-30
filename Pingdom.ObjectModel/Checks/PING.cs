using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pingdom.ObjectModel
{
    public class PingCheck : Check
    {
        public string host_name { get;set;}
        public PingCheck()
        {
            type = "PING";

        }
    }
}
