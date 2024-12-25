namespace _1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int CountKeyChanges(string s)
        {
            s = s.ToLower();
            int count = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != s[i - 1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
