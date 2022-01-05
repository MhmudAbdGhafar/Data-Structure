using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class PriorityQueue
    {
        private int[] items;
        private int front;
        private int rear;
        private int count;

        public PriorityQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void enqueue(int item)
        {
            if (isFull())
                throw new InvalidOperationException();


            int index = shiftItemsToInsert(item);
            items[index] = item;
            
            rear = increment(rear);
            count++;
        }

        public int dequeue()
        {
            if (isEmpty()) 
                throw new InvalidOperationException();

            var item = items[front];
            items[front] = 0;

            front = increment(front);
            count--;
            return item;
        }

        private bool isFull()
        {
            return count == items.Length;
        } 

        public bool isEmpty()
        {
            return count == 0;
        }

        private int increment(int i)
        {
            return (i + 1) % items.Length;
        }
        private int decrement(int i)
        {
            return (i - 1 + items.Length) % items.Length;
        }

        private int shiftItemsToInsert(int item)
        {
            if (isEmpty())
                return rear;

            int i = decrement(rear);
            while(i != decrement(front))
            {
                if (item < items[i])
                    items[increment(i)] = items[i];
                else
                    return increment(i);

                i = decrement(i);
            }
            return rear;
        }
    }
}
