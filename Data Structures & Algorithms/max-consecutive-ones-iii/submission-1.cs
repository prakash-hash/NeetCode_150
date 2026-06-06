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

/*
Modifying k Without Restoring It
When using k directly as a counter (decrementing when encountering zeros), remember that this mutates the input parameter. If you need to use k again later or if the problem requires preserving it, use a separate variable. Additionally, when shrinking the window, you must restore k by incrementing it when a zero leaves the window.

Incorrect Window Shrinking Condition
The window should shrink when k < 0, meaning we have flipped more zeros than allowed. A common mistake is using k == 0 as the shrinking condition, which prevents the window from ever containing k zeros. The window is valid as long as k >= 0; only shrink when it becomes negative.

Forgetting to Handle Edge Cases
When k equals or exceeds the number of zeros in the array, the answer is simply the length of the entire array. While the sliding window approach handles this naturally, the brute force approach might have issues if not carefully implemented. Also, handle the case when the array is empty or contains only ones.
*/