using System.Collections.Generic;

namespace _746MinCostClimbingStairs;

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new();
        int cost = sol.MinCostClimbingStairs([1, 100, 1, 1, 1, 100, 1, 1, 100, 1]);
    }

    public class Solution
    {
        Dictionary<int, int> MinimumCostOfIndex = new();

        public int MinCostClimbingStairs(int[] cost)
        {
            int OneCost = CalculateMinCost(cost, cost.Length - 1);
            int TwoCost = CalculateMinCost(cost, cost.Length - 2);

            if (OneCost > TwoCost)
            {
                return TwoCost;
            }

            return OneCost;
        }

        public int CalculateMinCost(int[] cost, int i)
        {
            if (i < 2)
            {
                return cost[i];
            }
            int CostOne = CalculateMinCost(cost, i - 1);
            int CostTwo = CalculateMinCost(cost, i - 2);
            int optimalPath;
            int value;
            if (MinimumCostOfIndex.TryGetValue(i - 1, out value))
            {
                CostOne = value;
            }
            else
            {
                CostOne = CalculateMinCost(cost, i - 1);
                MinimumCostOfIndex.Add(i - 1, CostOne);
            }
            if (MinimumCostOfIndex.TryGetValue(i - 2, out value))
            {
                CostTwo = value;
            }
            else
            {
                CostTwo = CalculateMinCost(cost, i - 2);
                MinimumCostOfIndex.Add(i - 2, CostTwo);
            }

            if (CostOne > CostTwo)
            {
                optimalPath = CostTwo;
            }
            else
            {
                optimalPath = CostOne;
            }
            return cost[i] + optimalPath;
        }
    }
}
