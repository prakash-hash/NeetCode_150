public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> checkDupList = new HashSet<int>();
        foreach(int num in nums){
            if(checkDupList.Contains(num)){
                return true;
            }

            checkDupList.Add(num);
        }
        return false;
    }
} 