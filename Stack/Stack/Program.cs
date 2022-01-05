using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack stack = new MinStack();
            stack.push(5);
            stack.push(2);
            stack.push(10);
            stack.push(1);

            Console.WriteLine(stack.min());

            stack.pop();

            Console.WriteLine(stack.min());
        }
    }
}
