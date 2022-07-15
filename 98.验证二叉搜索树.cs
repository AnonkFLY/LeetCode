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
public class Solution98
{
    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, long.MaxValue, long.MinValue);
    }
    private bool IsValidBST(TreeNode root, long max, long min)
    {
        if (root == null)
            return true;
        if (root.val >= max || root.val <= min)
            return false;
        return IsValidBST(root.left, root.val, min) && IsValidBST(root.right, max, root.val);
    }
}