using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class StringReverser
    {
        public string reverse(string input)
        {
            if (input == null)
                throw new InvalidOperationException();

            Stack<char> stack = new Stack<char>(); 

            foreach (var item in input)
                stack.Push(item);

            StringBuilder reversed = new StringBuilder();
            while(stack.Count != 0)
                reversed.Append(stack.Pop());

            return reversed.ToString();
        }
    }
}
