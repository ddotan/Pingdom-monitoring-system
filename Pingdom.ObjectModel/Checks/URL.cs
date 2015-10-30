using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pingdom.ObjectModel
{
    public class HTTPCheck : Check
    {
        public string website { get; set; }
        public string http_method { get; set; }
        public HTTPCheck()
        {
            type = "URL";
            http_method = "G";

        }
        
    }
}
