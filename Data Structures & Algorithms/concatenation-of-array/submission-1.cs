public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len = nums.Length;
        int len_2 = 2*len;
        int[] result = new int[2 * len];
        int k = 0;
        for(int i = 0; i < len_2; i++){
            result[i] = nums[k++];
            k = k == len ? 0 : k;
        }

        return result;
    }
}