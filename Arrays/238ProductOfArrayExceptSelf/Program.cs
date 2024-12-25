namespace _238ProductOfArrayExceptSelf;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] prefijo = new int[nums.Length];
            int[] sufijo = new int[nums.Length];
            prefijo[0] = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                prefijo[i + 1] = prefijo[i];
                prefijo[i + 1] *= nums[i];
            }
            sufijo[nums.Length - 1] = 1;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                sufijo[i - 1] = sufijo[i];
                sufijo[i - 1] *= nums[i];
            }
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefijo[i] * sufijo[i];
            }
            return result;
        }
    }
}
