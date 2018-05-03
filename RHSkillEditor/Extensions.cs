using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSkillEditor
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var attributes =
                (DescriptionAttribute[])value.GetType().GetField(value.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }

    public static class DictExtensions
    {
        public static bool TryAdd<k,v>(this Dictionary<k,v> dict, k key, v value)
        {
            try
            {
                dict.Add(key, value);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
