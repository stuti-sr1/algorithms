using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _605CanPlaceFlowers
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int i = 0;
            int count = 0;
            while (i< flowerbed.Length)
            {
                if (flowerbed[i]==0 && (i==0 || flowerbed[i-1] == 0) && (i==flowerbed.Length-1 ||flowerbed[i+1]==0))
                {
                    flowerbed[i] = 1;
                    count++;
                }
                if (count >= n) return true;
                i++;
            }
            return false;
        }

        //public static bool CanPlaceFlowers(int[] flowerbed, int n)
        //{
        //    if (flowerbed.Length == 1)
        //    {
        //        if (flowerbed[0] == 0 && n == 1) return true;
        //        else return false;
        //    }
        //    if (flowerbed[0] == 0 && flowerbed[1] == 0)
        //    {
        //        n--;
        //        flowerbed[0] = 1;
        //        if (n == 0) return true;
        //    }
        //    int i;
        //    for (i = 1; i < flowerbed.Length; i++)
        //    {
        //        if (n == 0) break;
        //        if (flowerbed[i] == 0)
        //        {
        //            if (flowerbed[i - 1] == 0)
        //            {
        //                n--;
        //                flowerbed[i] = 1;
        //            }
        //            else
        //                continue;
        //                //return false;                    
        //        }
        //        else
        //        {
        //            if (flowerbed[i] == 1) return false;
        //            else continue;
        //        }
        //    }
        //    if (n==0 && (i <= flowerbed.Length && flowerbed[i] == 0))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        
    }
}
