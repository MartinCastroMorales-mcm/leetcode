using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace _215KthLargestElementInAnArray;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> maxHeap = new();

            foreach (int n in nums)
            {
                maxHeap.Enqueue(n, 0 - n);
            }
            //int previus = maxHeap.Dequeue();
            int x = maxHeap.Peek();
            for (int i = 1; i < k; i++)
            {
                x = maxHeap.Dequeue();
            }
            return x;
        }
    }
}
