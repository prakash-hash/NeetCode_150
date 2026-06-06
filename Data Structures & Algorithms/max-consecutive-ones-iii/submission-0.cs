public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int l = 0;
        int zeroCount = 0;
        int max = 0;
        for(int r = 0; r < nums.Length; r++){
            if(nums[r] == 0){
                zeroCount++;
            }

            while(zeroCount > k){
                if(nums[l] == 0){
                    zeroCount--;
                }
                l++;
            }

            max = Math.Max(max, r - l + 1);
        }

        return max;
    }
}