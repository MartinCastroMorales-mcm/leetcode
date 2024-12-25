

namespace ContainsDuplicate;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new Solution();
        int[] nums = [1,2,3,1];
        Console.WriteLine(sol.ContainsDuplicate(nums));
    }

    public class Solution
    {
        Dictionary<int, bool> mapOfRepeated = new Dictionary<int,bool>();
        public bool ContainsDuplicate(int[] nums)
        {
            foreach (int n in nums)
            {
                if(!mapOfRepeated.ContainsKey(n)){
                    mapOfRepeated.Add(n, true);
                }else {
                    return false;
                }
                
            }
            return true;
        }
    }
}
