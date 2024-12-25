using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _242ValidAnagram;

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new();
        string s = "ab";
        string t = "a";
        bool result = sol.IsAnagram(s, t);
        Console.WriteLine(result);
    }

    class Solution
    {
        Dictionary<char, int> CharMap = new Dictionary<char, int>();

        public bool IsAnagram(string s, string t)
        {
            int value;
            //saveChars
            foreach (char c in s)
            {
                Console.Write("c: " + c);
                if (CharMap.TryGetValue(c, out value))
                {
                    Console.WriteLine(" value: " + value);
                    value++;
                }
                else
                {
                    value = 1;
                    Console.WriteLine(" value: " + 1);
                }
                CharMap[c] = value;
            }
            this.printMap(CharMap);
            //use chars
            foreach (char c in t)
            {
                if (CharMap.TryGetValue(c, out value))
                {
                    value--;
                    if (value == 0)
                    {
                        CharMap.Remove(c);
                    }
                    else
                    {
                        CharMap[c] = value;
                    }
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine("print2");
            this.printMap(CharMap);
            if(CharMap.Count == 0){
                return true;
            }
            return false;
        }

        public void printMap(Dictionary<char, int> map)
        {
            Dictionary<char, int>.KeyCollection charList = map.Keys;
            foreach (char c in charList)
            {
                int value = 0;
                map.TryGetValue(c, out value);
                Console.WriteLine("char: " + c + " value: " + value);
            }
        }
    }
}
