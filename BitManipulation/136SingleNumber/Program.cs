namespace _136SingleNumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int res = 0;
            foreach (int n in nums)
            {
                res = res ^ n;
            }
            return res;
        }
    }
}
