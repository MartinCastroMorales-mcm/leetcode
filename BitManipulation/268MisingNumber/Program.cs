namespace _268MisingNumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            int sum = 0;
            int max = -1;
            bool has0 = false;
            foreach (int n in nums) {
                sum += n;
                if(n > max) {
                    max = n;
                }
                if(n == 0) {
                    has0 = true;
                }
             }
             
             int maxSum = (max*(max +1))/2;

             int missing = maxSum - sum;
             if(missing == 0) {
                 missing = max+1;
             }
             if(!has0) {
                 return 0;
             }

             return missing;

        }
    }
}
