public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        int mid = 0;
        while(l <= r){
            mid = (l+r)/2;
            
            if(nums[mid] == target){
                return mid;
            }

            if(nums[mid] > target){
                r = mid - 1;
            }
            else{
                l = mid + 1;
            }
        }
        return -1;
    }
}
