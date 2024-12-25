namespace _219ContainsDuplicateII;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length && j < k; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }
        }
    }
}
