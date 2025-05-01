using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses.Algorithm
{
    public class ItemValidatorV1
    {
        public bool IsValid(string input) //the performance is 16ms
        {


            Stack<char> notClosed = new Stack<char>();
            while(input.Length > 0)
            {
                if (input.Length == 1)
                    return false;
                if (input.StartsWith(')') || input.StartsWith(']') || input.StartsWith('}') )
                    return false;

                while (input.StartsWith('(') || input.StartsWith('[') || input.StartsWith('{'))
                {
                    notClosed.Push(input[0]);
                    input = input.Remove(0, 1);
                }
                while (input.StartsWith(')') || input.StartsWith(']') || input.StartsWith('}'))
                {
                    if(notClosed.Count == 0)
                        return false;

                    if (input.StartsWith(')'))
                    {
                        if (notClosed.Pop() != '(')
                            return false;
                    }
                    else if (input.StartsWith(']'))
                    {
                        if (notClosed.Pop() != '[')
                            return false;
                    }
                    else
                    {
                        if (notClosed.Pop() != '{')
                            return false;
                    }
                    input = input.Remove(0, 1);
                }
            }

            if (notClosed.Count != 0)
                return false;
            return true;
        }
    }
}
