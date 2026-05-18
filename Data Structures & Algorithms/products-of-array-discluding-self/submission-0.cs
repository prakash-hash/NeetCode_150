public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] leftArr = new int[nums.Length];
        int[] rightArr = new int[nums.Length];
        int[] result = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            if(i == 0){
                leftArr[i] = 1;
            }
            else{
                leftArr[i] = leftArr[i-1]*nums[i-1];
            }
        }

        for(int i = nums.Length-1; i >= 0; i--){
            if(i == nums.Length-1){
                rightArr[i] = 1; 
            }
            else{
                rightArr[i] = rightArr[i+1]*nums[i+1];
            }
        }

        for(int i = 0; i < nums.Length; i++){
            result[i] = leftArr[i]*rightArr[i];
        }

        return result;
    }
}
