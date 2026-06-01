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
    public bool IsBalanced(TreeNode root) {
       return CheckBalance(root).isBalanced;
    }

    public (bool isBalanced, int height) CheckBalance(TreeNode root){
        if(root == null){
            return (true, 0);
        }

        (bool isBalanced, int height) left = CheckBalance(root.left);
        (bool isBalanced, int height) right = CheckBalance(root.right);


        
        return (Math.Abs(left.height - right.height) <= 1 && left.isBalanced && right.isBalanced, Math.Max(left.height, right.height)+1);

    }
}
