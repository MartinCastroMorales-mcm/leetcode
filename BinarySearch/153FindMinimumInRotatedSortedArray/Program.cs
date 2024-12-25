using System;

namespace _153FindMinimumInRotatedSortedArray;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int m = left + (right - left) / 2;
            if (nums[left] < nums[right])
            {
                return nums[left];
            }
            while (left < right)
            {
                if (nums[m] < nums[m - 1])
                {
                    return nums[m];
                }
                else if (nums[left] <= nums[m])
                {
                    left = m;
                }else {
                    right = m;
                }
                
                m = left + (right - left) / 2;
            }
            return Int32.MaxValue;
        }
    }
}
