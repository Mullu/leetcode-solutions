using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MatchingParenthesisImpl
    {
        public static Boolean hasMatchingParenthesis(string s)
        {
            var stack = new Stack<char>();

            for(int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                if (current == '(')
                {
                    stack.Push(current);
                }

                if (current == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
