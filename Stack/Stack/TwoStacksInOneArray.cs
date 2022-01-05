using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class TwoStack
    {
        private int top1;
        private int top2;
        private int[] items;

        public TwoStack(int capacity)
        {
            if(capacity <= 0)
                throw new InvalidOperationException();

            items = new int[capacity];
            top1 = -1;
            top2 = capacity;
        }

        public void push1(int item)
        {
            if (isFull1())
                throw new StackOverflowException();

            items[++top1] = item;
        }

        public int pop1()
        {
            if (isEmpty1())
                throw new InvalidOperationException();

            return items[top1--];
        }

        public bool isFull1()
        {
            return top1 + 1 == top2;
        }

        public bool isEmpty1()
        {
            return top1 == -1;
        }

        public void push2(int item)
        {
            if (isFull2())
                throw new StackOverflowException();

            items[--top2] = item;
        }

        public int pop2()
        {
            if (isEmpty2())
                throw new InvalidOperationException();

            return items[top2++];
        }

        public bool isFull2()
        {
            return top2 - 1 == top1;
        }

        public bool isEmpty2()
        {
            return top2 == items.Length;
        }
        
    }
}
