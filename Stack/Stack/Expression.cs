using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Expression
    {
        private const string leftBrackets = "([{<";
        private const string rightBrackets = ")]}>";
        private string input;

        public Expression(string input)
        {
            this.input = input;
        }

        private bool isBracketMatched(char opened, char closed)
        {
            return leftBrackets.IndexOf(opened) == rightBrackets.IndexOf(closed);
        }
        private bool isLeftBracket(char ch)
        {
            return leftBrackets.Contains(ch);
        }

        private bool isRightBracket(char ch)
        {
            return rightBrackets.Contains(ch);
        }
        public bool isBalanced()
        {
            if (input == null)
                throw new InvalidOperationException();

            Stack<char> stack = new Stack<char>();
            foreach (var ch in input)
            {
                if (isLeftBracket(ch))
                    stack.Push(ch);
                else if (isRightBracket(ch))
                {
                    if (stack.Count == 0)
                        return false;

                    var top = stack.Pop();
                    if (!isBracketMatched(top, ch))
                        return false; 
                }
            }

            return stack.Count == 0;
        }
    }
}
