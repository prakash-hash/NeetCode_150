public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;

        for (int i = 0; i <= heights.Length; i++)
        {
            int currHeight = (i == heights.Length) ? 0 : heights[i];

            while (stack.Count > 0 && currHeight < heights[stack.Peek()])
            {
                int height = heights[stack.Pop()];

                int left = stack.Count == 0 ? -1 : stack.Peek();

                int width = i - left - 1;

                maxArea = Math.Max(maxArea, height * width);
            }

            stack.Push(i);
        }

        return maxArea;
    }
}