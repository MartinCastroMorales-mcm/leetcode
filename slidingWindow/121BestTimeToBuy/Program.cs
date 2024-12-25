namespace _121BestTimeToBuy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        int maxProfit = sol.MaxProfit([1, 1, 0]);
        Console.WriteLine("maxProfit: " + maxProfit);
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int buyI = 0;
            int sellI = 0;
            if(prices.Length < 2){
                return maxProfit;
            }
            int currentProfit = 0;
            for(int i = 1; i < prices.Length; i++) {
                if(prices[sellI] < prices[i]) {
                    sellI = i;
                    currentProfit = prices[sellI] - prices[buyI];
                    if(currentProfit > maxProfit) {
                        maxProfit = currentProfit;
                    }
                }else if(prices[buyI] > prices[i]){
                    buyI = i;
                    sellI = i;
                }
                
            }
            return maxProfit;
        }
    }
}
