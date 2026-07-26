// public class Solution {
//     public int MajorityElement(int[] nums) {
//         Array.Sort(nums);
//         return nums[nums.Length/2];
//     }
// }

public class Solution {
    public int MajorityElement(int[] nums) {
        int res = 0;
        int count = 0;
        
        foreach(int n in nums){
            if(count == 0){
                res = n;
            }

            count += (n == res ? 1 : -1);
        }

        return res;
    }
}

/*
Optimal Solution (Boyer-Moore Voting Algorithm)

The optimal solution doesn't require sorting.
*/