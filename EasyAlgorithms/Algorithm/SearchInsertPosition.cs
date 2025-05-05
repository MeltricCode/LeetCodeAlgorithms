using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAlgorithms.Algorithm
{
    public class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target) //the performance is 0ms
        {
            int low = 0;
            int high = (nums.Length - 1);

            while (low <= high)
            {
                int middle = low + (high - low) / 2;

                if (nums[middle] == target)
                {
                    return middle;

                }
                else if (nums[middle] < target)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }
            return low;
        }
    }
}
