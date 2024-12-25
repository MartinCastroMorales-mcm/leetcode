namespace _15_3Sum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> superLista = new();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0)
                {
                    while (nums[i - 1] == nums[i])
                    {
                        i++;
                        if (i == nums.Length)
                        {
                            return superLista;
                        }
                    }
                }

                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int jMasK = nums[j] + nums[k];
                    if (nums[i] + jMasK == 0)
                    {
                        superLista.Add([nums[i], nums[j], nums[k]]);
                        j++;
                        k--;
                    }
                    else if (jMasK < nums[i])
                    {
                        j++;
                    }
                    else if (jMasK > nums[i])
                    {
                        k--;
                    }
                }
            }
            return superLista;
        }
    }
}
