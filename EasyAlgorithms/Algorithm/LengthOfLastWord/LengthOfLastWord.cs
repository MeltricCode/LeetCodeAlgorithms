using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAlgorithms.Algorithm.LengthOfLastWord
{
    // Problem Url: https://leetcode.com/problems/length-of-last-word/
    public class LastWorld
    {
        public static int LengthOfLastWord(string s) // the performance is 0ms
        {
            s = s.Trim();
            int counter = 0;
            for(int i = s.Length - 1; i>=0; i--)
            {
                if (s[i] == ' ')
                    return counter;
                counter++;
            }
            return counter;
        }
    }
}
