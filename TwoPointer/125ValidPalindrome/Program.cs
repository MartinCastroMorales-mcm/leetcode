using System;
namespace _125ValidPalindrome;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        bool val = sol.IsPalindrome("race a car");
        Console.WriteLine(val);
    }

    public class Solution
    {
        public bool IsPalindrome(string s) { 
            s = s.ToLower();
            s = s.Replace(" ", "");
            string ss = "";
            for(int i = 0; i < s.Length; i++) {
                char c = s[i];
                if((c <= 122 && c >= 97) ||(c >= 48 && c <= 57) ){
                    Console.WriteLine("c: " + c);
                    ss += c;
                }
            }
            for(int i = 0; i < ss.Length; i++) {
                Console.WriteLine("s[i]: " + ss[i] + " s[s.Length -1 -i]: " + ss[ss.Length -1 -i]);
                if(ss[i] != ss[ss.Length-i-1]){
                    return false;
                }
            }
            return true;
        }
    }
}
