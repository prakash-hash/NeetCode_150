public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indexMap = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++){
            int rest = target - nums[i];
            if(indexMap.ContainsKey(rest)){
                return new int[]{indexMap[rest], i};
            }
            indexMap[nums[i]] = i;
        }

        return null;
    }
}
