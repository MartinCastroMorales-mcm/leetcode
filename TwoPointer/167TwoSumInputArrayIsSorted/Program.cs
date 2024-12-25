namespace _167TwoSumInputArrayIsSorted;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] + numbers[j] == target) {
                        return [i+1, j+1];
                    }
                }
            }
            return null;
        }
    }
}
