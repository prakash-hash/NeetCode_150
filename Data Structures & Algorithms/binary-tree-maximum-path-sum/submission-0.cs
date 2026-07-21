/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution
{
    private int ans = int.MinValue;

    public int MaxPathSum(TreeNode root)
    {
        DFS(root);
        return ans;
    }

    private int DFS(TreeNode node)
    {
        if (node == null)
            return 0;

        int left = Math.Max(0, DFS(node.left));
        int right = Math.Max(0, DFS(node.right));

        // Best path passing through this node
        ans = Math.Max(ans, left + right + node.val);

        // Return best single branch upward
        return node.val + Math.Max(left, right);
    }
}
