using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibReFinder
{
    public static class RegEx
    {
        public static List<string>  GetValuesToArray(string str , string pattern)
        {
            Match[] array_matches = Regex.Matches(str, pattern).Cast<Match>().ToArray();
            List<string> new_list = new List<string>();
            string value_ = "";
            foreach (var item in array_matches)
            {
                value_ = item.Value.Trim();
                if(!new_list.HasValue(value_) && value_ != string.Empty)
                    new_list.Add(item.Value);
            }
            return new_list;
        }
    }
}
