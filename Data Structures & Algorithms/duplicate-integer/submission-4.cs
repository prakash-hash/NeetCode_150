public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length == 0)
        {
            return false;
        }
        return new HashSet<int>(nums).Count < nums.Length;
    }
} 