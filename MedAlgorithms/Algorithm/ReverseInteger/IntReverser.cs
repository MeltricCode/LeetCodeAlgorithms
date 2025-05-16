using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAlgorithms.Algorithm.ReverseInteger
{
    //Problem url: https://leetcode.com/problems/reverse-integer
    public class IntReverser
    {
        public static int Reverse(int x)
        {
            if (x < 10 && x > -10)
                return x;

            StringBuilder number = new StringBuilder(x.ToString());
            StringBuilder builder = new StringBuilder();
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            if(number[0] == '-')
                builder.Append(number[0]);
            for(int i = number.Length - 1; i >= 0; i--)
            {
                if (builder.Length == 0 && number[i] == '0')
                {
                    number[i] = '#';
                }
                if (numbers.Contains(number[i]))
                {
                    builder.Append(number[i]);
                }
            }
            return int.Parse(builder.ToString());
        }
    }
}
