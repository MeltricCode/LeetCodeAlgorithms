using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAlgorithms.Algorithm.LongestCommonPrefix
{
    // Problem url: https://leetcode.com/problems/longest-common-prefix/
    public class Prefix
    {
        public static string LongestCommonPrefixV1(string[] strs)
        {
            if (strs.Length == 1)
                return strs[0];
            int arrayMinLenght = strs[0].Length;
            foreach (var item in strs)
            {
                if (arrayMinLenght > item.Length)
                    arrayMinLenght = item.Length;
            }

            int lastSameIndex = -1;
            bool exit = false;
            //each string
            for (int i = 0; i < strs.Length - 1; i++)
            {
                if (exit)
                    break;
                //each char in string
                for (int b = 0; b < arrayMinLenght; b++)
                {
                    if ((i - 1) >= 0 && strs[i - 1][b] != strs[i + 1][b])
                    {
                        if (arrayMinLenght == 1)
                            lastSameIndex = lastSameIndex - 1;
                        exit = true;
                        break;
                    }
                    if (strs[i][b] == strs[i + 1][b])
                    {
                        lastSameIndex = b;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (lastSameIndex + 1 < 0)
                return "";
            return strs[0].Substring(0, lastSameIndex + 1);
        }

        public static string LongestCommonPrefixV2(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix))
                        return "";
                }
            }
            return prefix;
        }
    }
}
