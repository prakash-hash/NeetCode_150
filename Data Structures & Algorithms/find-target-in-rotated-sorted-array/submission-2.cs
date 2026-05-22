public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0; 
        int r = nums.Length - 1;
        int mid = 0;
        
        while(l <= r){
            mid = (l+r)/2;

            if(target == nums[mid]){
                return mid;
            }

            if(nums[l] <= nums[mid]){
                if(target > nums[mid] || target < nums[l]){
                    l = mid + 1;
                }
                else{
                    r = mid - 1;
                }
            }
            else{
                if(target < nums[mid] || target > nums[r]){
                    r = mid - 1;
                }
                else
                {
                    l = mid +1;
                }
            }
        }

        return -1;
    }
}
