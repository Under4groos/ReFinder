using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibReFinder
{
    public static class SString
    {
        public static string GetStringIndex(this string str, int i ,int d)
        {
            //if (str.Length == 0 && str.Length < i && str.Length < d)
            //    return "";
            if (i < 0)
                return "";
            if(d > str.Length)
            {
                return str.GetStringIndex(i, str.Length);
            }
            string str_ = "";
            for (int s = i; s < d; s++)
            {
                str_ += str[s];
            }
            return str_;
        }

        public static List<string> StringSplitMulti(this string str , int[] table_int)
        {
            List<string> str_ = new List<string>();
            int _last_int = table_int[0];
            foreach (int item in table_int)
            {
                
                str_.Add(str.GetStringIndex(_last_int, item));
                _last_int = item;
            }
            return str_;
        }
        public static bool HasValue(this string[] array , string str)
        {
            foreach (var item in array)
            {
                if(item == str)
                    return true;
            }
            return false;
        }
        public static bool HasValue(this List<string> array, string str)
        {
            foreach (var item in array)
            {
                if (item == str)
                    return true;
            }
            return false;
        }
        public static List<InString> FindIndex(this string str, string[] find_array)
        {

            string str_add = "";
            string str_add_last = "";
            List<InString> list = new List<InString>();
            foreach (string find_str in find_array)
            {
                for (int i = 0; i < str.Length; i++)
                {

                    str_add = str.GetStringIndex(i, i + find_str.Length);
                    if (str_add == find_str && str_add_last != str_add)
                    {


                        list.Add(
                        new InString()
                        {
                            value = str_add,
                            start = i,
                            end = i + find_str.Length
                        });
                        str_add_last = str_add;
                    }
                }
            }
            return list;
        }

        
        
    }
}
