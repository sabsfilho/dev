public class MaxProfitSolution {
    public int MaxProfit(int[] prices) {
        /*
        
        Best Time to Buy and Sell Stock

        profit = sell future - buy present > 0
        max profit = max(current,previous)

        */

        int max = 0;

        for(int i=0; i < prices.Length; i++)
        {
            for(int j = i + 1; j < prices.Length; j++)
            {
                int profit = prices[j] - prices[i];
                max = Math.Max(profit, max);
            }
        }

        return max;
        
    }
}
