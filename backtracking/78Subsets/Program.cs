using System;
using System.Collections.Generic;

namespace _78Subsets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> conjuntoPotencia = new();
            int subSetTmp;

            for(int subSet = 0; subSet < Math.Pow(2,nums.Length); subSet++) {
                subSetTmp = subSet;
                List<int> conjunto = new();
                for(int i = 0; i < nums.Length; i++) {
                    if((subSetTmp & 1) == 1) {
                        conjunto.Add(nums[i]);
                    }
                    Console.WriteLine("before BitShift: " + subSetTmp);
                    subSetTmp = subSetTmp >> 1;
                    Console.WriteLine("after BitShift: " + subSetTmp);
                }
                conjuntoPotencia.Add(conjunto);
            }
            return conjuntoPotencia;
        }
    }
}
