namespace _1046LastStoneWeight;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public PriorityQueue<int, int> heap = new();

        public int LastStoneWeight(int[] stones)
        {
            foreach (int n in stones)
            {
                heap.Enqueue(n, Int32.MaxValue - n);
            }
            int firstLargest = 0;
            int seccondLargest = 0;
            int weight;
            while (heap.Count > 1)
            {
                firstLargest = heap.Dequeue();
                seccondLargest = heap.Dequeue();
                if (firstLargest > seccondLargest)
                {
                    weight = firstLargest - seccondLargest;
                    heap.Enqueue(weight, Int32.MaxValue - weight);
                }
                else if (seccondLargest > firstLargest)
                {
                    weight = seccondLargest - firstLargest;
                    heap.Enqueue(weight, Int32.MaxValue - weight);
                }
            }
            if(heap.Count == 0) {
                return 0;
            }
            return heap.Dequeue();
        }
    }
}
