public class Solution {
    public int FindMax(int[] nums, int i, int j){
        int max = int.MinValue;

        for(int k = i; k <= j; k++){
            max = Math.Max(max, nums[k]); 
        }

        return max;
    }

    public int[] MaxSlidingWindow(int[] nums, int k) {
        int i = 0;
        int j = k - 1;
        List<int> maxList = new();
        
        while(j < nums.Length){
            maxList.Add(FindMax(nums, i, j));
            i++;
            j++;
        }

        return maxList.ToArray();
    }
}
