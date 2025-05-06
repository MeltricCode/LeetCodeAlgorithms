using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAlgorithms.Algorithm.RemoveElement
{
    public class ElementRemover
    {
        public static int RemoveElement(int[] nums, int val) //the performance is 0ms
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
