public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
        foreach(int n in nums){
            result ^= n;
        }

        return result;
    }
}
