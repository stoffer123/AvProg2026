using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    public static class ParantesStak
    {
        public static bool IsBalancedStack(string input)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> matchingPairs = new()
            {
                {')', '(' },
                {']', '[' },
                {'}', '{' }
            };

            foreach(char c in input)
            {
                if(c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if(c == ')' || c == ']' || c == '}')
                {
                    if(stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();
                    if(top != matchingPairs[c])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;

        }
    }
}
