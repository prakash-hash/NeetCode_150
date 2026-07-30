public class Solution {
    public void SortColors(int[] nums) {
        int zeroCount = 0;
        int oneCount = 0;
        int twoCount = 0;

        foreach (int n in nums) {
            if (n == 0) {
                zeroCount++;
            } else if (n == 1) {
                oneCount++;
            } else {
                twoCount++;
            }
        }

        int k = 0;

        for (int i = 0; i < zeroCount; i++) nums[k++] = 0;

        for (int i = 0; i < oneCount; i++) nums[k++] = 1;

        for (int i = 0; i < twoCount; i++) nums[k++] = 2;
    }
}