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
    public int GoodNodes(TreeNode root) {
        return RecursiveF(root.val, root);
    }

    public int RecursiveF(int max, TreeNode node){
        if(node == null){
            return 0;
        }

        int count = 0;

        if(max <= node.val){
            max = node.val;
            count++;
        }

        count += RecursiveF(max, node.left);
        count += RecursiveF(max, node.right);

        return count;
    }
}
