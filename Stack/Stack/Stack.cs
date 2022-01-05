using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack
    {
        private int[] items = new int[5];
        private int count = 0;

        public void push(int item)
        {
            if (count == items.Length)
                throw new StackOverflowException();

            items[count++] = item;
        }

        public int pop()
        {
            if (count == 0)
                throw new InvalidOperationException();

            return items[--count];
        }

        public int peek()
        {
            if (count == 0)
                throw new InvalidOperationException();

            return items[count - 1];
        }

        public bool isEmpty()
        {
            return count == 0;
        } 
      
    }
}
