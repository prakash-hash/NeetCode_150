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
    public List<List<int>> LevelOrder(TreeNode root) {
        if(root == null){
            return new List<List<int>>();
        }

        List<List<int>> result = new();
        Queue<(TreeNode n, int h)> q = new();
        q.Enqueue((root, 1));
        
        while(q.Count != 0){
            (TreeNode n, int h) front = q.Dequeue();
            if(front.n.left != null){
                q.Enqueue((front.n.left, front.h + 1));
            }
            if(front.n.right != null){
                q.Enqueue((front.n.right, front.h + 1));
            }
            if(result.Count < front.h){
                result.Add(new List<int>());
            }
            result[front.h-1].Add(front.n.val);
        }

        return result;
    }
}
