using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EasyAlgorithms.Algorithm.PlusOne
{
    //problem url: https://leetcode.com/problems/plus-one
    public class LastIndexPlusOne
    {
        //this impl has bad performance because of BigInteger
        //I should use Carry, Sum approach to solve it
        public static int[] PlusOne(int[] digits) // the performance is 21ms 
        {
            StringBuilder builder = new();
            foreach (int digit in digits)
            {
                builder.Append(digit);
            }
            BigInteger resultNumber = BigInteger.Parse(builder.ToString()) + 1;
            string resultStr = resultNumber.ToString();
            int[] result = new int[resultStr.Length];
            for(int i = 0; i< resultStr.Length; i++)
            {
                result[i] = int.Parse(resultStr[i].ToString());
            }
            return result;
        }
    }
}
