namespace _338;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            int numOfDigitsUsed = 1;
            int numOfOnes = 0;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = numOfOnes;
                numOfOnes++;
                if (numOfOnes > numOfDigitsUsed)
                {
                    numOfOnes = 1;
                    numOfDigitsUsed++;
                }
            }
            return result;
        }
        
    }
}
