using System.Runtime.Versioning;

namespace _347TopKFrequetElements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        Console.WriteLine("###### Start #####");
        int[] topK = sol.TopKFrequent([1,1,1,2,2,3], 2);
        sol.printArray(topK);
        Console.WriteLine("###### Start #####");
        topK = sol.TopKFrequent([1], 1);
        sol.printArray(topK);
        Console.WriteLine("###### Start #####");
        topK = sol.TopKFrequent([5,3,1,1,1,3,73,1], 2);
        Console.WriteLine("Solution: ");
        sol.printArray(topK);
    }
    

    public class Solution
    {
        public void printArray(int[] nums) {
        Console.Write("[");
        foreach(int n in nums) {
            Console.Write(n + " ");
        }
        Console.WriteLine("]");
    }
        public int[] TopKFrequent(int[] nums, int k)
        {
            if(nums.Length == k) {
                return nums;
            }
            int distinct = -1;
            int[] topK = new int[k];
            int[] AmountOfRepeats = new int[k];
            Dictionary<int, int> map = new();
            //find repeats
            foreach (int n in nums)
            {
                if (!map.TryAdd(n, 1))
                {
                    map[n] = map[n] + 1;
                }else {
                    Console.WriteLine("n:" + n);
                    distinct++;
                    nums[distinct] = n;
                    
                }
                
            }
            Console.WriteLine("distinct:" + distinct);
            this.printArray(nums);
            Console.WriteLine("valores unicos: " + (distinct+1));
            for (int i = 0; i <= distinct; i++)
            {
                Console.WriteLine("i: " + i + " nums[i] " + nums[i] + " map[nums[i]]: " + map[nums[i]] + " k: " +k);
                //Console.WriteLine("AmountOfRepeats");
                //this.printArray(AmountOfRepeats);
                //Console.WriteLine("topK");
                //this.printArray(topK);
                checkAndAddMax(nums[i], map[nums[i]], AmountOfRepeats, topK, k);
            }
            return topK;
        }

        public void checkAndAddMax(int candidate, int repeats, int[] maxValues, int[] topK, int k)
        {
            if (maxValues[k - 1] < repeats)
            {
                int tmpAmount;
                int tmpCandidate;
                maxValues[k - 1] = repeats;
                topK[k-1] = candidate;
                for (int i = k - 2; i >= 0; i--)
                {
                    if (maxValues[i] < repeats) 
                    { 
                        tmpAmount = maxValues[i];
                        maxValues[i] = repeats;
                        maxValues[i + 1] = tmpAmount;

                        tmpCandidate = topK[i];
                        topK[i] = candidate;
                        topK[i + 1] = tmpCandidate;
                    }else {
                        return;
                    }
                }
            }
        }
    }
}
