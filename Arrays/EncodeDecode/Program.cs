using System;
using System.Collections.Generic;

namespace EncodeDecode;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Solution sol = new();
        List<string> list = ["VeryLongStringWithoutAnySpacesOrSpecialCharactersRepeatedManyTimesVeryLongStringWithoutAnySpacesOrSpecialCharactersRepeatedManyTimes"]
;
        string s = sol.Encode(list);
        List<string> result = sol.Decode(s);
        foreach(string line in result) {
            Console.WriteLine("[" + line + "]");
        }
    }

    public class Solution
    {
        public string Encode(IList<string> strs)
        {
            String message = "";

            for(int i = 0; i < strs.Count; i++) {
                message += strs[i];
                if(i != strs.Count-1) {
                    message += "\n";
                }
            }
            return message;

        }

        public List<string> Decode(string s) { 
            List<string> list = new();
            string[] sGroup = s.Split("\n");
            foreach(string line in sGroup) {
                list.Add(line);
            }
            return list;
        }
    }
}
