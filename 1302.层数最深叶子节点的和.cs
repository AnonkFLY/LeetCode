/*
 * @lc app=leetcode.cn id=1302 lang=csharp
 *
 * [1302] 层数最深叶子节点的和
 */

// @lc code=start

using System;
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
public class Solution1302 {
    public int DeepestLeavesSum(TreeNode root) {
        int sum = 0;
        int maxLevel = 0;
        GetDeepestLeavesSum(root,0,ref sum,ref maxLevel);
        return sum;
    }

    private void GetDeepestLeavesSum(TreeNode node,int level,ref int sum,ref int maxLevel)
    {
        if(node==null)
            return;
        if(level>maxLevel)
        {
            sum = node.val;
            maxLevel = level;
        }else if(level==maxLevel)
        {
            sum += node.val;
        }
        GetDeepestLeavesSum(node.right,level+1,ref sum,ref maxLevel);
        GetDeepestLeavesSum(node.left,level+1,ref sum,ref maxLevel);
    }
}
// @lc code=end

