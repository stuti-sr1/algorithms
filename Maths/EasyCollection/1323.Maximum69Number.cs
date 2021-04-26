using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection
{
    public static class Maximum69Number
    {
        public static int Maximum69NumberFun(int num)
        {
            int r = 0, i = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            while (num > 0)
            {
                r = num % 10;
                map[i++] = r;
                num /= 10;
            }
            int count = 0;
            for (int j = map.Count - 1; j >= 0; j--)
            {
                if (map.ContainsKey(j) && map[j] == 6 && count == 0)
                {
                    map[j] = 9;
                    count++;
                }
                else if (count > 0) break;
            }
            int newNum = 0;
            for (int j = map.Count - 1; j >= 0; j--)
            {
                newNum = newNum * 10 + map[j];
            }
            return newNum;
        }
    }
}
