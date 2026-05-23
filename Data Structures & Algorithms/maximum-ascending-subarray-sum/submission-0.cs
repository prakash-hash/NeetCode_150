public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int count = nums[0];
        int maxCount = count;

        for(int i = 0; i < nums.Length - 1; i++){
            if(nums[i] < nums[i+1]){
                count += nums[i+1];
            }
            else{
                count = nums[i+1];
            }
            maxCount = Math.Max(count, maxCount);
        }

        return maxCount;
    }
}