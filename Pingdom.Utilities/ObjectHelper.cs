using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Pingdom.Utilities
{
    public static class ObjectHelper
    {
        public static void InsertValueIntoObjectProp(object inputObject, string propertyName, object propertyVal)
        {
            Type type = inputObject.GetType();
            System.Reflection.PropertyInfo propertyInfo = type.GetProperty(propertyName);
            Type propertyType = propertyInfo.PropertyType;
            var targetType = IsNullableType(propertyInfo.PropertyType) ? Nullable.GetUnderlyingType(propertyInfo.PropertyType) : propertyInfo.PropertyType;
            propertyVal = Convert.ChangeType(propertyVal, targetType);
            propertyInfo.SetValue(inputObject, propertyVal, null);
        }
        private static bool IsNullableType(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>));
        }
    }
}

