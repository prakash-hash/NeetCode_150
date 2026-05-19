public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0;
        int j = heights.Length-1;
        int maxArea = 0;
        while(i < j){
            maxArea = Math.Max(maxArea, (j-i)*Math.Min(heights[i], heights[j]));
            if(heights[i] < heights[j]){
                i++;
            }
            else{
                j--;
            }
        }
        return maxArea;
    }
}

/*
Common Pitfalls
Moving the Wrong Pointer
The algorithm requires moving the pointer at the shorter height inward. Moving the taller pointer instead never increases the area (since height is limited by the shorter side) and can cause the algorithm to miss the optimal solution.

Confusing This Problem with Trapping Rain Water
Unlike the Trapping Rain Water problem where you need to sum water trapped between bars, this problem finds a single container formed by two lines. Applying the wrong mental model leads to incorrect area calculations.

Off-by-One Errors in Width Calculation
The width between indices l and r is r - l, not r - l + 1. Using the wrong formula overestimates the area by one unit for every pair, leading to incorrect results.
*/