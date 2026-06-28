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
    public List<int> RightSideView(TreeNode root) {
        if(root == null){
            return new List<int>();
        }

        List<int> rightSide = new();
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        while(q.Count > 0){
            int size = q.Count;
            TreeNode front = null;
            for(int i = 0; i < size; i++){
                front = q.Dequeue();
                
                if(front.left != null){
                    q.Enqueue(front.left);
                }
                if(front.right != null){
                    q.Enqueue(front.right);
                }
            }
            
            rightSide.Add(front.val);
        }

        return rightSide;
    }
}
