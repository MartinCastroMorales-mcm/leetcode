using System.Collections.Generic;

namespace _3LongestSubstringWithoutRepeatingCharacters;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        int n = sol.LengthOfLongestSubstring("pwwkew");
        Console.WriteLine("Solution: " + n);
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(s.Length == 0) {
                return 0;
            }
            Dictionary<char, bool> map = new();
            int Length = 0;
            int MaxLength = 0;
            int start;
            for (int i = 0; i < s.Length; i++)
            {
                start = i;
                Length = 1;
                map.Add(s[start], true);
                for (int j = start + 1; j < s.Length; j++)
                {
                    if (!map.TryAdd(s[j], true))
                    {
                        map = new();
                        if (Length > MaxLength)
                        {
                            MaxLength = Length;
                        }
                        break;
                    }
                    Length++;
                }
                map = new();
                        if (Length > MaxLength)
                        {
                            MaxLength = Length;
                        }

            }
            return MaxLength;
        }
    }
}
