namespace _287FindTheDuplicateNumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return nums[i];
                }
            }
            return -1;//modifique el array. Tenia que usar el algoritmo de floyd
        }
    }
}
