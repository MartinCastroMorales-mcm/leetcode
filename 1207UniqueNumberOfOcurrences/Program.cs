using System;
using System.Collections.Generic;

namespace _1207UniqueNumberOfOcurrences;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> map = new();
            Array.Sort(arr);
            Console.WriteLine("print sortedArr");
            this.printArr(arr);
            int occurrences = 1;
            int currentNumer = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (currentNumer != arr[i])
                {
                    if (!map.TryAdd(occurrences, 1))
                    {
                        return false;
                    }
                    currentNumer = arr[i];
                    occurrences = 1;
                }else {
                occurrences++;
                }
            }
            return true;
        }
        public void printArr(int[] arr){
            foreach(int n in arr) {
                Console.WriteLine(n);
            }
        }
    }
}
