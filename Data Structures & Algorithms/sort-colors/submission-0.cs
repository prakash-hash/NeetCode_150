public class Solution {
    public void SortColors(int[] nums) {
        int zeroCount = 0;
        int oneCount = 0;
        int twoCount = 0;

        foreach(int n in nums){
            if(n == 0){
                zeroCount++;
            }
            else if(n == 1){
                oneCount++;
            }
            else{
                twoCount++;
            }
        }

        int k = 0;
        while(zeroCount > 0 || oneCount > 0 || twoCount > 0){
            if(zeroCount > 0){
                nums[k++] = 0;
                zeroCount--;
            }
            else if(oneCount > 0){
                nums[k++] = 1;
                oneCount--;
            }
            else{
                nums[k++] = 2;
                twoCount--;
            }
        }
    }
}