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

public class Codec
{
    // Encodes a tree to a single string.
    public string Serialize(TreeNode root)
    {
        List<string> result = new();

        void Dfs(TreeNode node)
        {
            if (node == null)
            {
                result.Add("#");
                return;
            }

            result.Add(node.val.ToString());

            Dfs(node.left);
            Dfs(node.right);
        }

        Dfs(root);

        return string.Join(",", result);
    }


    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data)
    {
        string[] values = data.Split(',');
        int index = 0;

        TreeNode Build()
        {
            if (values[index] == "#")
            {
                index++;
                return null;
            }

            TreeNode node = new TreeNode(
                int.Parse(values[index])
            );

            index++;

            node.left = Build();
            node.right = Build();

            return node;
        }

        return Build();
    }
}
