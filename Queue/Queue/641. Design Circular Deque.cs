using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class DesignCircularDeque
    {
        public void DesignCircularDequeFun()
        {
            MyCircularDeque circularDeque = new MyCircularDeque(3);
            circularDeque.InsertLast(1);            // return true
            circularDeque.InsertLast(2);            // return true
            circularDeque.InsertFront(3);           // return true
            circularDeque.InsertFront(4);           // return false, the queue is full
            int t= circularDeque.GetRear();            // return 2
            circularDeque.IsFull();             // return true
            circularDeque.DeleteLast();         // return true
            circularDeque.InsertFront(4);           // return true
            t=circularDeque.GetFront();
        }

    }
    public class MyCircularDeque
    {
        public int[] dequeue;
        public int capacity = 0;
        public int front { get; set; }
        public int rear { get; set; }
        public int count { get; set; }

        /** Initialize your data structure here. Set the size of the deque to be k. */
        public MyCircularDeque(int k)
        {
            dequeue = new int[k];
            this.capacity = k;
            this.front = -1;
            this.rear = -1;
            this.count = 0;
        }

        /** Adds an item at the front of Deque. Return true if the operation is successful. */
        public bool InsertFront(int value)
        {
            if (IsFull()) return false;
            front = (front - 1 + capacity) % capacity;
            if (count == 0) rear = front;
            dequeue[front] = value;
            count++;
            return true;
        }

        /** Adds an item at the rear of Deque. Return true if the operation is successful. */
        public bool InsertLast(int value)
        {
            if (IsFull()) return false;
            rear = (rear + 1) % capacity;
            if (count == 0) front = rear;
            dequeue[rear] = value;
            count++;
            return true;
        }

        /** Deletes an item from the front of Deque. Return true if the operation is successful. */
        public bool DeleteFront()
        {
            if (IsEmpty()) return false;
            front = (front + 1) % capacity;
            count--;
            return true;
        }

        /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
        public bool DeleteLast()
        {
            if (IsEmpty()) return false;
            rear = (rear - 1 + capacity) % capacity;
            count--;
            return true;
        }

        /** Get the front item from the deque. */
        public int GetFront()
        {
            if (IsEmpty()) return -1;
            return dequeue[(front + capacity) % capacity];
        }

        /** Get the last item from the deque. */
        public int GetRear()
        {
            if (IsEmpty()) return -1;
            return dequeue[(rear + capacity) % capacity];
        }

        /** Checks whether the circular deque is empty or not. */
        public bool IsEmpty()
        {
            return count == 0;
        }

        /** Checks whether the circular deque is full or not. */
        public bool IsFull()
        {
            return count == capacity;
        }
    }
}
