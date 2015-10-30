using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pingdom.ObjectModel
{
    public class Check
    {
        public Check()
        {
            timeout = 20;
            user_group_ids = new List<string>();
        }
        public string display_name { get; set; }
        public int check_frequency { get; set; }
        public string type { get; set; }
        public int timeout { get; set; }
        public string location_profile_id { get; set; }
        public string notification_profile_id { get; set; }
        public string monitor_group_id { get; set; }
        public string threshold_profile_id { get; set; }
        public List<string> user_group_ids { get; set; }


    }
}
