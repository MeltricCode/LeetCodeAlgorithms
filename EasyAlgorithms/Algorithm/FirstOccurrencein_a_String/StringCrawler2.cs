using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAlgorithms.Algorithm.FirstOccurrencein_a_String
{
    public class StringCrawler2
    {
        public static int FindFirsIndex(string haystack, string needle) //the performance is 8ms
        {
            if (needle == "") return 0;
            if (needle.Length > haystack.Length) return -1;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j = 0;
                while (j < needle.Length && haystack[i + j] == needle[j])
                {
                    j++;
                }
                if (j == needle.Length) return i;
            }

            return -1;
        }
    }
}
