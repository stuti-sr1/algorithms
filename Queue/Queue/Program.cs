using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberofRecentCalls objNumberofRecentCalls = new NumberofRecentCalls();
            int[] time = { 1, 100, 3001, 3002 };
            var t = objNumberofRecentCalls.NumberofRecentCallsFun(time);

            DesignCircularDeque objDesignCircularDeque = new DesignCircularDeque();
            objDesignCircularDeque.DesignCircularDequeFun();

            DesignCircularQueue objDesignCircularQueue = new DesignCircularQueue();
            objDesignCircularQueue.DesignCircularQueueFun();
            Console.ReadKey();
        }
    }
}
