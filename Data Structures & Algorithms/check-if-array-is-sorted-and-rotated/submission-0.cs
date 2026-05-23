public class Solution {
    public bool Check(int[] nums) {
        int length = nums.Length;
        if(length == 1){
            return true;
        }

        int count = 1;
        for(int i = 0; i < length*2 - 1; i++){
            if(nums[i%length] <= nums[(i+1)%length]){
                count++;
            }
            else{
                count = 1;
            }
            if(count == length){
                return true;
            }
        }
        return false;
    }
}