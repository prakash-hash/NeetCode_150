public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;

        while (l < r)
        {
            int mid = l + (r - l) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return nums[l] < target ? l + 1 : l;
    }
}