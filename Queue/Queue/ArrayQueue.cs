using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class ArrayQueue
    {
        private int[] items = new int[5];
        private int front;
        private int rear;
        private int count;
        public void enqueue(int item)
        {
            if (isFull())
                throw new InvalidOperationException();

            items[rear] = item;
            rear = (rear + 1) % items.Length;
            count++;
        }
        public int dequeue()
        {
            if (isEmpty())
                throw new InvalidOperationException();
            
            var item = items[front];
            items[front] = 0;
            front = (front + 1) % items.Length;
            count--;
            return item;
        }
        public int peek()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            return items[front];
        }
        public bool isFull()
        {
            return count == items.Length;
        }
        public bool isEmpty()
        {
            return count == 0;
        }

        public string print()
        {
            string ans = "";
            foreach (var item in items)
            {
                ans += item;
            }
            return ans;
        }
    }
}
