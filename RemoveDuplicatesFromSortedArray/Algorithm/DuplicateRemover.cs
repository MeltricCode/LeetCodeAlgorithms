using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedArray.Algorithm
{
    public class DuplicateRemover
    {
        public int ArrayUniqueCounter(int[] nums) // the performance is 0ms
        {
            if(nums.Length == 0)
            return 0;

            int i = 0;

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}
