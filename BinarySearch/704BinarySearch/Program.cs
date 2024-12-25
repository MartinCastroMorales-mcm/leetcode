
namespace _704BinarySearch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        Console.WriteLine("\n\nTest 1");
        int index = sol.Search([-1,0,3,5,9,12], 9);
        Console.WriteLine("index: " + index);
        Console.WriteLine("\n\nTest 2");
        index = sol.Search([-1,0,3,5,9,12], 2);
        Console.WriteLine("index: " + index);
        Console.WriteLine("\n\n Test 6");
        index = sol.Search([-1,0,3,5,9,12], -1);
        Console.WriteLine("index: " + index);
        Console.WriteLine("\n\nTest 3");
        index = sol.Search([5], 5);
        Console.WriteLine("index: " + index);
        Console.WriteLine("\n\nTest 4");
        index = sol.Search([2,5], 2);
        Console.WriteLine("index: " + index);
        Console.WriteLine("\n\nTest 5");
        index = sol.Search([-1,0,5], 5);
        Console.WriteLine("index: " + index);
        
    }
    class Solution{
        public int Search(int[] nums, int value){
            int left = 0;
            int right = nums.Length-1;
            int m;

            while(right >= left) {
                m = left + (right-left)/2;
                if(nums[m] < value) {
                    left = m+1;
                }else if(nums[m] > value){
                    right = m - 1;
                }else {
                    return m;
                }
            }

            return -1;
        }
    }

    
}
