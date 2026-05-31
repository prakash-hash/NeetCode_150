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
        return DiameterOfBT(root).diameter;
    }

    public (int diameter, int height) DiameterOfBT(TreeNode root){
        
        if(root == null){
            return (0, 0);
        }

        (int diameter, int height) left = DiameterOfBT(root.left);
        (int diameter, int height) right = DiameterOfBT(root.right);

        int maxDiameter = Math.Max(left.height + right.height, Math.Max(left.diameter, right.diameter));

        return (maxDiameter, Math.Max(left.height, right.height) + 1);
    }
}
