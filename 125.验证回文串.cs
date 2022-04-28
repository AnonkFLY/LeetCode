/*
 * @lc app=leetcode.cn id=125 lang=csharp
 *
 * [125] 验证回文串
 */

// @lc code=start
using System;
public class Solution125
{
    //最开始还是做个简单的先,性能真拉...慢慢来，算法挺头疼的
    public bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;
        s = s.ToLower();
        while (j - i > 0)
        {
            while (i < j && !Char.IsLetterOrDigit(s[i]))
                i++;
            while (j > i && !Char.IsLetterOrDigit(s[j]))
                j--;
            Console.WriteLine($"对比{i}:[{s[i]}] and {j}:[{s[j]}]");
            if (s[i] != s[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
// @lc code=end

