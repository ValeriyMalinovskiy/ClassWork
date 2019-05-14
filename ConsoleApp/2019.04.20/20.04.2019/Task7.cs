using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019Apr20
{
    class Task7
    {
        public static string CamelCaser(string str)
        {
            StringBuilder sb = new StringBuilder();
            bool isToUpper=false;
            for (int i = 0; i < str.Length; i++)
            {
                if((str[i].Equals('_')) || (str[i].Equals('-')))
                {
                    isToUpper = true;
                    continue;
                }
                if (isToUpper)
                {
                    sb.Append(str[i].ToString().ToUpper());
                }
                else
                {
                    sb.Append(str[i]);
                }
                isToUpper = false;
            }
            return sb.ToString();
        }
    }
}
