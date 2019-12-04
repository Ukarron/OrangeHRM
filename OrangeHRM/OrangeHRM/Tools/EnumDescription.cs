using System;
using System.Reflection;

namespace OrangeHRM.Tools
{
    public static class EnumDescription
    {
        public static string GetEnumDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            System.ComponentModel.DescriptionAttribute[] attributes =
                (System.ComponentModel.DescriptionAttribute[])
                fi.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
        
        public static T GetEnumByDescription<T>(string value)
        {
            if (Enum.IsDefined(typeof(T), value))
            {
                return (T)Enum.Parse(typeof(T), value, true);
            }
            else
            {
                string[] enumNames = Enum.GetNames(typeof(T));
                foreach (string enumName in enumNames)
                {
                    object e = Enum.Parse(typeof(T), enumName);
                    if (value == GetEnumDescription((Enum)e))
                    {
                        return (T)e;
                    }
                }
            }
            throw new ArgumentException("The value '" + value
                + "' does not match a valid enum name or description.");
        }
    }
}
