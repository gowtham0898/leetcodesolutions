public class Solution {
    public int MaxProfit(int[] prices) {
       int max_profit = 0;
       int l = 0;
       int profit = 0;
       for(int r = 1; r < prices.Length; r++){
        // my purchare should be lower
        // else shift the left pointer to right(which is lowest then before)
         if(prices[l] < prices[r]){
            profit = prices[r] - prices[l];
         }
         else{
            l = r;
         }
         if(max_profit < profit){
            max_profit = profit;
         }
       }
       return max_profit;
    }

    
}