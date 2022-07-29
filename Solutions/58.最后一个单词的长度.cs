/*
 * @lc app=leetcode.cn id=58 lang=csharp
 *
 * [58] 最后一个单词的长度
 */

// @lc code=start
public class Solution58
{
    //前面想做二叉树，结果来个TreeNode类，再见
    public int LengthOfLastWord(string s)
    {
        int result = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                if (result > 0)
                    break;
                continue;
            }
            result++;
        }
        return result;
    }
}
// @lc code=end

