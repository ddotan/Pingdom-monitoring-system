using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pingdom.Utilities
{
    public static class WebServicesHelper
    {
        public static string BuildPostString(object i_Obj)
        {
            string result = string.Empty;
            string valueBuilder;
            var properties = i_Obj.GetType().GetProperties();

            foreach (var propertyInfo in properties)
            {
                object obj = propertyInfo.GetValue(i_Obj, null);
                if (obj != null)
                {
                    if(propertyInfo.Name.ToLower() == "name")
                    {
                        valueBuilder = obj.ToString().Replace(' ', '+');
                        result += propertyInfo.Name.ToLower() + "=" + valueBuilder;
                    }else
                    {
                    valueBuilder = obj.ToString().Replace(' ', '+');
                    result += (propertyInfo.Name + "=" + valueBuilder).ToLower();
                    }
                    result += "&";
                }

            }
            if (!string.IsNullOrEmpty(result))
            {
                result = result.Remove(result.Length - 1, 1);
            }
            return result;
        }
    }
}
