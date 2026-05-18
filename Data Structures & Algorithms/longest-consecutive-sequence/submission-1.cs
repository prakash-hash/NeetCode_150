public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int,int> set = new Dictionary<int,int>();
        int max = 0;
        foreach(int num in nums){
            if(!set.ContainsKey(num)){
                set[num] = set.GetValueOrDefault(num-1,0) + set.GetValueOrDefault(num+1,0) + 1;

                set[num - set.GetValueOrDefault(num-1,0)] = set[num];
                set[num + set.GetValueOrDefault(num+1,0)] = set[num];

                max = Math.Max(max, set[num]);
            }
        }
        return max;
    }
}
