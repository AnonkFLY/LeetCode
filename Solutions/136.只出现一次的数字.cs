/*
 * @lc app=leetcode.cn id=136 lang=csharp
 *
 * [136] 只出现一次的数字
 */

// @lc code=start
public class Solution136
{
    //自认为还行的结果寄了 6.43% and 28.26% -4.30
    public int SingleNumber(int[] nums)
    {
            int? nInt = null;
            int cureent = nums[0];
            bool onSuff = false;
            for (int i = 0; i < nums.Length; i++)
            {
                cureent = nums[i];
                if (nInt != null && cureent == nInt)
                    continue;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (cureent == nums[j])
                    {
                        nInt = nInt ?? cureent;
                        nums[j] = (int)nInt;
                        onSuff = false;
                        break;
                    }
                    onSuff = true;
                }
                if (onSuff)
                    break;
            }
            return cureent;
    }
}
// @lc code=end

