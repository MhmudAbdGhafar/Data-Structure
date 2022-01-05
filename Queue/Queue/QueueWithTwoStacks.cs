using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class QueueWithTwoStacks
    {
        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();

        public void enqueue(int item)
        {
            stack1.Push(item);
        }

        public int dequeue()
        {
            if (isEmpty())
                throw new InvalidOperationException();
            
            
            moveStack1ToStack2();
            return stack2.Pop();
        }


        public int peek()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            
            moveStack1ToStack2();
            return stack2.Peek();
        }

        private void moveStack1ToStack2()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count != 0)
                    stack2.Push(stack1.Pop());
            }
        }
        public bool isEmpty()
        {
            return stack1.Count == 0 && stack2.Count == 0; 
        }
        
    }
}
