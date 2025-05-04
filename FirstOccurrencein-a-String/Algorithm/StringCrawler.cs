using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOccurrencein_a_String.Algorithm
{
    public class StringCrawler
    {
        public static int FindFirsIndex(string haystack, string needle) //the performance is 8ms
        {
            return haystack.IndexOf(needle);
        }
    }
}
