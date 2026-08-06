public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> numsMap = new();
        for(int i = 0; i < nums.Length; i++){
            if(numsMap.ContainsKey(nums[i]) && i - numsMap[nums[i]] <= k){
                return true;
            }
            numsMap[nums[i]] = i;
        }
        return false;
    }
}