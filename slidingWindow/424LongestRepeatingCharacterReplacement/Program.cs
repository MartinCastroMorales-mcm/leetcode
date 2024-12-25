using System.Collections.Generic;

namespace _424LongestRepeatingCharacterReplacement;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        int result = sol.CharacterReplacement("AABABBA", 1);
        Console.WriteLine(result);
    }

    public class Solution
    {
        public class LetterNode {
            public int count;
            public char letter;
        }
        public int CharacterReplacement(string s, int k)
        {
            List<LetterNode> listLetterCount = new();
            int left = 0;
            int right = 0;
            int totalLetterCount = 0;
            int maxValueRepetitions = 0;
            while(right < s.Length) {
                //Procesing
                char c = s[right];
                bool flag = false;
                foreach(LetterNode node in listLetterCount) {
                    if(node.letter == c) {
                        node.count++;
                        flag = true;
                        break;
                    }
                }
                if(!flag) {
                    LetterNode node = new();
                    listLetterCount.Add(node);
                }
                //check if needs to shrink
                foreach(LetterNode node in listLetterCount) {
                    totalLetterCount++;
                    if(node.count > maxValueRepetitions) {
                        maxValueRepetitions = node.count;
                    }
                }
                totalLetterCount -= maxValueRepetitions;
                if(totalLetterCount < k) {
                    left++;
                }else {
                    right++;
                }
            }
            return maxValueRepetitions + k;
            
        }
    }
}
