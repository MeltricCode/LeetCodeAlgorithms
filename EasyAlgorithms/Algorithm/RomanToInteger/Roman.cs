using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAlgorithms.Algorithm.PalindromeNumber
{
    public class Roman
    {
        private readonly ReadOnlyDictionary<string, int> _roman = new(new Dictionary<string, int>()
            {
                { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 },
                { "C", 100 }, { "D", 500 }, { "M", 1000 }
            });

        public static int ToNormalNumber(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int value = _roman[s[i].ToString()];
                if (i + 1 < s.Length && value < _roman[s[i + 1].ToString()])
                {
                    sum -= value;
                }
                else
                {
                    sum += value;
                }
            }
            return sum;
        }
    }
}
