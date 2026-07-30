public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int r = 1;
        int maxP = 0;

        while (r < prices.Length)
        {
            if (prices[l] < prices[r])
            {
                int profit = prices[r] - prices[l];

                if (profit > maxP)
                    maxP = profit;
            }
            else
            {
                l = r;
            }

            r += 1;
        }

        return maxP;
    }
}
