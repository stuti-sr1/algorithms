using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _735AsteroidCollision
    {
        public static int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int asteroid in asteroids)
            {
                if (asteroid > 0 || stack.Count == 0 || stack.Peek() < 0)
                {
                    stack.Push(asteroid);
                }
                else
                {
                    int newVal = asteroid;
                    while (stack.Count > 0 && stack.Peek() > 0 && newVal < 0)
                    {
                        int value = stack.Pop();
                        if (Math.Abs(value) == Math.Abs(newVal))
                        {
                            newVal = 0;
                            break;
                        }
                        else
                        {
                            newVal = Math.Abs(value) > Math.Abs(newVal) ? value : newVal;
                        }
                    }
                    if (newVal != 0)
                    {
                        stack.Push(newVal);
                    }
                }
            }
            int[] res = new int[stack.Count];
            int i = stack.Count - 1;
            while (stack.Count > 0)
            {
                res[i--] = stack.Pop();
            }
            return res;
        }
        
    }
}
