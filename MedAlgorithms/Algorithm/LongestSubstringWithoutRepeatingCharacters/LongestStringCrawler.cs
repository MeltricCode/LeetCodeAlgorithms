using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAlgorithms.Algorithm.LongestSubstringWithoutRepeatingCharacters
{
    //Probblem url: https://leetcode.com/problems/longest-substring-without-repeating-characters
    public class LongestStringCrawler
    {
        public static int LengthOfLongestSubstring(string s) //The performance is 6ms
        {
            HashSet<char> charSet = new HashSet<char>();
            int left = 0, maxLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while (charSet.Contains(s[i]))
                {
                    charSet.Remove(s[left]);
                    left++;
                }

                charSet.Add(s[i]);

                maxLength = Math.Max(maxLength, i - left + 1);
            }
            return maxLength;
        }
    }
}
