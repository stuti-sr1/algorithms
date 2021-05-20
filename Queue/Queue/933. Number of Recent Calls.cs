using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class NumberofRecentCalls
    {
        public int[] NumberofRecentCallsFun(int[] time)
        {
            RecentCounter obj = new RecentCounter();
            int[] result = new int[time.Length];
            int i = 0;
            foreach ( int t in time)
            {
                result[i++]= obj.Ping(t);
            }
            return result;
        }        
    }
    public class RecentCounter
    {
        public Queue<int> queue { get; set; }
        public RecentCounter()
        {
            this.queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            queue.Enqueue(t);
            while (queue.Peek() < t - 3000)
            {
                int data = queue.Dequeue();
            }
            return queue.Count;
        }
    }
}
