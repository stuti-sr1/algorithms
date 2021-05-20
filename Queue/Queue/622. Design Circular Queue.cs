using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class DesignCircularQueue
    {
        public void DesignCircularQueueFun()
        {
            MyCircularQueue myCircularQueue = new MyCircularQueue(3);
            myCircularQueue.EnQueue(1); // return True
            myCircularQueue.EnQueue(2); // return True
            myCircularQueue.EnQueue(3); // return True
            myCircularQueue.EnQueue(4); // return False
            int t = myCircularQueue.Rear();     // return 3
            myCircularQueue.IsFull();   // return True
            myCircularQueue.DeQueue();  // return True
            myCircularQueue.EnQueue(4); // return True
            t = myCircularQueue.Rear();     // return 4

            //MyCircularQueue myCircularQueue = new MyCircularQueue(2);
            //myCircularQueue.EnQueue(4); // return True
            //int t = myCircularQueue.Rear();     // return 3
            //myCircularQueue.EnQueue(9); // return True
            //myCircularQueue.DeQueue();  // return True
            //myCircularQueue.Front();
            //myCircularQueue.DeQueue();  // return True
            //myCircularQueue.DeQueue();  // return True
        }
    }

    public class MyCircularQueue
    {
        public int[] queue { get; set; }
        public int front { get; set; }
        public int rear { get; set; }
        public int count { get; set; }
        //public int capacity { get; set; }
        public MyCircularQueue(int k)
        {
            queue = new int[k];
            //this.capacity = k;
            this.count = 0;
            front = -1;
            rear = -1;
        }

        public bool EnQueue(int value)
        {
            if (IsFull()) return false;
            //rear = (rear + 1 + capacity) % capacity;
            rear = (rear + 1 + queue.Length) % queue.Length;
            if (count == 0)
            {
                front = rear;
            }
            queue[rear] = value;
            count++;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty()) return false;
            //front = (front + 1 + capacity) % capacity;
            front = (front + 1 + queue.Length) % queue.Length;
            if (count == 0)
            {
                rear = front;
            }
            int data = queue[front];
            count--;
            return true;
        }

        public int Front()
        {
            if (IsEmpty()) return -1;
            //return queue[(front + capacity) % capacity];
            return queue[(front + queue.Length) % queue.Length];

        }

        public int Rear()
        {
            if (IsEmpty()) return -1;
            //return queue[(rear + capacity) % capacity];
            return queue[(rear + queue.Length) % queue.Length];

        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == queue.Length;// capacity;
        }
    }
}
