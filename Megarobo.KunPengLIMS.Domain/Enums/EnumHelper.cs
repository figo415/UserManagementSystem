using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Megarobo.KunPengLIMS.Domain.Enums
{
    public static class EnumHelper
    {
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0
                       ? attributes[0].Description
                       : null;
        }

        public static EnumType GetValueByDescription<EnumType>(string description)
        {
            var type = typeof(EnumType);
            if (!type.IsEnum) throw new ArgumentException("This method is destinated for enum types only.");
            foreach (var enumName in Enum.GetNames(type))
            {
                var enumValue = Enum.Parse(type, enumName);
                if (description == ((Enum)enumValue).GetDescription())
                    return (EnumType)enumValue;
            }
            throw new ArgumentException("There is no value with this description among specified enum type values.");
        }
    }
}
