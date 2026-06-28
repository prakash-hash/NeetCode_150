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

/*
Common Pitfalls
Using Strictly Greater Than Instead of Greater Than or Equal
A node is "good" if its value is greater than OR EQUAL to all ancestors. Using node.val > maxVal instead of node.val >= maxVal causes the root and equal-valued paths to be missed.

Initializing maxVal Too High
Starting with maxVal = 0 or maxVal = root.val can cause issues with negative values. Initialize with negative infinity or the root's value to correctly count the root as a good node.

# Wrong: misses root if root.val < 0
dfs(root, 0)

# Correct: root is always good
dfs(root, float('-inf'))
Sharing maxVal Across Sibling Subtrees
The maximum value must be tracked per-path, not globally. Updating a shared variable instead of passing the new max to each recursive call causes incorrect comparisons across different branches.
*/
