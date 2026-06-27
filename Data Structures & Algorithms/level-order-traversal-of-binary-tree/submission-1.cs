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

/*
public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        if (root == null)
            return result;

        Queue<TreeNode> q = new();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int size = q.Count;
            List<int> level = new();

            for (int i = 0; i < size; i++)
            {
                TreeNode node = q.Dequeue();
                level.Add(node.val);

                if (node.left != null)
                    q.Enqueue(node.left);

                if (node.right != null)
                    q.Enqueue(node.right);
            }

            result.Add(level);
        }

        return result;
    }
}
*/


/*
Common Pitfalls
Processing Nodes Individually Instead of by Level
In BFS, you must process all nodes at the current level before moving to the next. A common mistake is to pop nodes one at a time without tracking how many belong to the current level. This causes nodes from different levels to be mixed together in the same output list.

Not Handling the Empty Tree Case
When the root is null, the function should return an empty list. Forgetting this check can lead to null pointer exceptions when attempting to add the root to the queue or access its value.
*/
