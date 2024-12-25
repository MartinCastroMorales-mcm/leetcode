using System.Collections.Generic;

namespace _567PermutationInString;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public class Word
        {
            public string permutation = "";
            public int[] letterCount = new int[26];
        }

        public bool CheckInclusion(string s1, string s2)
        {
            int[] letterCount = new int[26];

            foreach (char c in s1)
            {
                int pos = c - 'a';
                letterCount[pos]++;
            }
            
            List<Word> list = new();
            
            foreach (char c in s2)
            {
                Word w = new();
                list.Add(w);
                int i = 0;
                while(i < list.Count) {
                    int pos = c - 'a';
                    Word word = list[i];
                    if (letterCount[pos] > word.letterCount[pos])
                    {
                        word.permutation += c;
                        word.letterCount[pos]++;
                        i++;
                        if (word.permutation.Length == s1.Length)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        list.Remove(word);
                    }
                }
            }
            return false;
        }
    }
}
