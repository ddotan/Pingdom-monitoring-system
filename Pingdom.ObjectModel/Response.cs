using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pingdom.ObjectModel
{
 public   class Response
    {
     //0 => success
        //401 =>invalid authtoken
        //201 => created
     public int code { get; set; }
     public string message { get; set; }

    }
}
