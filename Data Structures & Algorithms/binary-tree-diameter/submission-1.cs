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

public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) {
        int maxDiameter = 0;
        DiameterOfBinaryTree(root, ref maxDiameter);

        return maxDiameter;
    }

    public int DiameterOfBinaryTree(TreeNode root, ref int maxDiameter){
        
        if(root == null){
            return 0;
        }

        int left = DiameterOfBinaryTree(root.left, ref maxDiameter);
        int right = DiameterOfBinaryTree(root.right, ref maxDiameter);

        maxDiameter = Math.Max(maxDiameter, left+right);

        return Math.Max(left, right) + 1;

    }
}
