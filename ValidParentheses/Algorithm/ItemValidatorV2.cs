using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses.Algorithm
{
    public class ItemValidatorV2
    {
        public bool IsValid(string s) // the performance is 1ms
        {
            if(s.Length % 2 != 0)
                return false;

            Stack<char> stack = new();

            for(int i = 0; i < s.Length; i++)
            {
                char par = s[i];
                if(par == '(' || par == '[' || par == '{')
                {
                    stack.Push(par);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char expectedParan = par == ')' ? '(' : par == ']' ? '[' : '{';
                    char lastItem = stack.Pop();

                    if (lastItem != expectedParan)
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
