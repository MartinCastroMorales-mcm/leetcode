namespace greedy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = Int32.MinValue;
            int sum = 0;
            foreach (int n in nums)
            {
                sum += n;
                
                if (sum < n) { 
                    sum = n;
                }
                if(sum > maxSum) {
                    maxSum = sum;
                }
                
            }
            return maxSum;
        }
    }
}
