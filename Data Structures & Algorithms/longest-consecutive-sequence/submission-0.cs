public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int max = 0;
        foreach(int num in nums){
            if(!set.Contains(num-1)){
                int localMax = 1;
                int _num = num;
                while(set.Contains(_num+1)){
                    localMax++;
                    _num++;
                }
                if(localMax > max){
                    max = localMax;
                }
            }
        }
        return max;
    }
}
