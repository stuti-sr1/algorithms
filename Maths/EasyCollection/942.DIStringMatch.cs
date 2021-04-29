using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection
{
    public static class DIStringMatch
    {

        public static int[] DiStringMatch(string s)
        {
            int len = s.Length, i = 0;
            int j = len, k = 0;
            int[] result = new int[(len + 1)];
            for (k = 0; k < len; k++)
            {
                if (s[k] == 'D') result[k] = j--;
                else if (s[k] == 'I') result[k] = i++;
                else return result;
            }
            result[k] = i;
            return result;
        }

        //public static int[] DiStringMatch(string s)
        //{
        //    int j = s.Length, i = 0, k = 0;
        //    int[] result = new int[(j + 1)];
        //    foreach (char ch in s)
        //    {
        //        if (ch == 'D') result[k++] = j--;
        //        else if (ch == 'I') result[k++] = i++;
        //        else return result;
        //    }
        //    result[k++] = i;
        //    return result;
        //}
    }
}
