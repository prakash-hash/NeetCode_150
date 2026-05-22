public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int r = 1;
        int max = 0;
        while(r < prices.Length){
            if(prices[l] < prices[r]){
                max = Math.Max(max, prices[r]-prices[l]);
            }
            else{
                l = r;
            }
            r++;
        }
        return max;
    }
}
