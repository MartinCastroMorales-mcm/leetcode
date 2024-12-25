using System;
using System.Reflection.Emit;

namespace _875KokoEatingBananas;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        sol.MinEatingSpeed([1,42,3], 2);
    }
    public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        Array.Sort(piles);
        foreach(int n in piles) {
            Console.WriteLine(n);
        }

        int s = h - piles.Length;
        int min = piles[piles.Length - s - 1];
        
        
        
        return 0;
    }
    
}
}
