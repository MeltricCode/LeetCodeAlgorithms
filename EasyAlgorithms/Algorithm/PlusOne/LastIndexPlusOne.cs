using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAlgorithms.Algorithm.PlusOne
{
    //problem url: https://leetcode.com/problems/plus-one
    public class LastIndexPlusOne
    {
        public static int[] PlusOne(int[] digits)
        {
            int index = digits.Length - 1;

            if (digits[index] == 9)
            {
                var array = new int[digits.Length + 1];
                for(int i = 0; i<digits.Length; i++)
                {
                    array[i] = digits[i];
                }
                array[index] = 1;
                array[index + 1] = 0;
                return array;
            }
            else
            {
                digits[index]++;
                return digits;
            }
        }
    }
}
