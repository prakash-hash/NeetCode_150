public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        Backtrack(0, nums, new List<int>(), result);
        return result;
    }

    private void Backtrack(int index, int[] nums, List<int> current, List<List<int>> result) {
        result.Add(new List<int>(current));

        for (int i = index; i < nums.Length; i++) {
            current.Add(nums[i]);
            Backtrack(i + 1, nums, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
