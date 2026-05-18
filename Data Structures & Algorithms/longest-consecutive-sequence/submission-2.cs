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

/*
Common Pitfalls
Starting a Sequence from Every Number
A common inefficiency is to start counting a sequence from every number in the array, which leads to O(n^2) time complexity. The key optimization is to only start counting from numbers that are the beginning of a sequence (i.e., num - 1 is not in the set).

Not Handling Duplicates Properly
The input array may contain duplicate values. Using a set automatically handles this, but if you iterate over the original array instead of the set, you may process the same sequence multiple times, wasting computation.

Forgetting to Handle Empty Input
When the input array is empty, the longest consecutive sequence has length 0. Some implementations that assume at least one element exists may fail or return incorrect results for this edge case.
*/