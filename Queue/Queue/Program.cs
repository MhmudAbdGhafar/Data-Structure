using System;
using System.Collections.Generic;
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);

            q = reverseFirstKElelmentsfromQueue(q, 3);

            while (q.Count != 0)
            {
                Console.WriteLine(q.Dequeue());
            }

        }

        public static Queue<int> reverseFirstKElelmentsfromQueue(Queue<int> queue, int k)
        {
            if (k < 0 || k > queue.Count)
                throw new InvalidOperationException();

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < k; i++)
                 stack.Push(queue.Dequeue());

            while (stack.Count != 0)
                queue.Enqueue(stack.Pop());

            for (int i = 0; i < queue.Count - k; i++)
                queue.Enqueue(queue.Dequeue());

            return queue;
        }

        public static void reverse(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while(queue.Count != 0)
            {
                var current = queue.Dequeue();
                stack.Push(current);
            }

            while(stack.Count != 0)
            {
                var current = stack.Pop();
                queue.Enqueue(current);
            }
        }
    }
}
