using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class LinkedQueue
    {
        private LinkedList<int> items;
        private int count;

        public void enqueue(int item)
        {
            items.AddLast(item);
            count++;
        }
        public int dequeue()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            var item = items.First.Value;
            items.RemoveFirst();
            count--;
            return item;
        }
        public bool isEmpty()
        {
            return count == 0;
        }
        public int size()
        {
            return count;
        }

        public int peek()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            return items.First.Value;
        }
    }

}
