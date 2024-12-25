using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;

namespace _39CombinatorialSum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        List<IList<int>> superList = new List<IList<int>>(sol.CombinationSum([2,3,6,7], 7));
        foreach(List<int> list in superList) {
            Console.Write("[");
            foreach(int n in list) {
                Console.Write(n + ",");
            }
            Console.WriteLine("]");
        }
    }

    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> superList = new();
            List<int> list = new();
            backtracking(candidates, target, superList, list);
            return superList;
        }

        public void backtracking(
            int[] candidates,
            int target,
            List<IList<int>> superList,
            List<int> list,
            int sum = 0,
            int index =0
        ) { 
            //reject
            if(sum > target) {
                return;
            }   
            //accept list
            if(sum == target) {
                superList.Add(list);
            } 

            while(index < candidates.Length)
            {
                List<int> newList = new();
                for(int i = 0; i < list.Count; i++) {
                    newList.Add(list[i]);
                }
                newList.Add(candidates[index]);
                backtracking(candidates, target, superList, newList, sum+candidates[index], index);
                index++;
            }
        }

        

    }
}
