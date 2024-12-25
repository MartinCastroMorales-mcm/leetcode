using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _49GroupAnagrams;

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new();
        IList<IList<string>> anagramList = sol.GroupAnagrams(
            //["eat","tea","tan","ate","nat","bat"]
            ["hhhhu", "tttti", "tttit", "hhhuh", "hhuhh", "tittt"]
        );
        PrintListOfLists(anagramList);
    }

    public static void PrintListOfLists(IList<IList<string>> List)
    {
        foreach (IList<string> l in List)
        {
            Console.Write("[ ");
            foreach (string s in l)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("]");
        }
    }

    class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<Dictionary<char, int>> listOfAnagrams = new();
            List<IList<string>> groupAnagrams = new();
            foreach (string s in strs)
            {
                //checkIfAnagram Exists In List
                Dictionary<char, int> mapOfS = this.CreateAnagram(s);
                int indexOfAnagram = WhatAnagram(listOfAnagrams, mapOfS, s, groupAnagrams);
                if(indexOfAnagram == -1) {
                    //IfNotCreateAndAddAnagramToList
                    listOfAnagrams.Add(mapOfS);
                    List<string> newAnagram = new();
                    newAnagram.Add(s);
                    groupAnagrams.Add(newAnagram);
                }else {
                    //If does exist add to the corresponding one
                    groupAnagrams[indexOfAnagram].Add(s);
                }
                
                
            }
            return groupAnagrams;
        }

        /*
        returns the index of the list and dictionary(they are equal) that the string belongs to
        returns -1 if no anagram is found
        */
        public int WhatAnagram(
            List<Dictionary<char, int>> listOfAnagrams,
            Dictionary<char, int> mapOfS,
            string s,
            List<IList<string>> groupAnagram
        )
        {
            Dictionary<char, int> map;
            for(int i = 0; i < listOfAnagrams.Count; i++) {
                map = listOfAnagrams[i];
                if (IsAnagram(map, mapOfS, s, groupAnagram[i][0])) { 
                    return i;
                }
            }
            Console.WriteLine("not found");
            return -1;
        }

        public bool IsAnagram(Dictionary<char, int> map, Dictionary<char, int> mapOfS, string s, string otherS)
        {
            if (s.Length != otherS.Length)
            {
                //Console.WriteLine("diferent size " + map.Count);
                return false;
            }
            int value;
            int valueOfC;
            foreach (char c in s)
            {
                if (!map.TryGetValue(c, out value))
                {
                    //Console.WriteLine("diferent chars in map");
                    return false;
                }
                if (!mapOfS.TryGetValue(c, out valueOfC))
                {
                    //Console.WriteLine("diferent chars in mapOfS");
                    return false;
                }
                if (value != valueOfC)
                {
                    //Console.WriteLine("diferent ammount");
                    return false;
                }
            }
            return true;

            //TODO: edit prefered braces
        }

        public Dictionary<char, int> CreateAnagram(string s)
        {
            Dictionary<char, int> map = new();
            foreach (char c in s)
            {
                if (map.TryAdd(c, 1)) { }
                else
                {
                    map[c] = map[c] + 1;
                }
            }
            return map;
        }
    }
}
