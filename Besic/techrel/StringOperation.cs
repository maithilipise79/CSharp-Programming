using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besic
{
    public  class StringOperation
    {
        public static string ConcatenateStrings(string str1,string str2)
        {
            return str1 + str2;

        }

        public static string CompareString(string str1,string str2)
        {
            string str = (str1 == str2) ? "String are equal" : "String are not equal";
            return str;

        }

        public static string UpperCase(string str)
        {
            return str.ToUpper();
        }

        public static string LowerCase(string str)
        {
            return str.ToLower();
        }
    }
}
