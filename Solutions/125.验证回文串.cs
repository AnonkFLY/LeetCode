/*
 * @lc app=leetcode.cn id=125 lang=csharp
 *
 * [125] 验证回文串
 */

// @lc code=start
using System;
public class Solution125
{
    //最开始还是做个简单的先,性能真拉...慢慢来，算法挺头疼的-4.28
    //优化之后: -4.30
    ///untime beats 100 % of csharp submissions 
    /// Your memory usage beats 64.49 % of csharp submissions (39.4 MB)

    
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();
        char[] str = new char[s.Length];
        int strIndex = 0;
        int i;
        for( i =0;i<str.Length;i++)
        {
            if(Char.IsLetterOrDigit(s[i]))
            {
                str[strIndex] = s[i];
                strIndex++;
            }
        }
        for(i =0;i<strIndex/2;i++)
        {
            if(str[i]!=str[strIndex-i-1])
                return false;
        }
        return true;
        // int i = 0;
        // int j = s.Length - 1;
        // s = s.ToLower();
        // while (j - i > 0)
        // {
        //     while (i < j && !Char.IsLetterOrDigit(s[i]))
        //         i++;
        //     while (j > i && !Char.IsLetterOrDigit(s[j]))
        //         j--;
        //     Console.WriteLine($"对比{i}:[{s[i]}] and {j}:[{s[j]}]");
        //     if (s[i] != s[j])
        //     {
        //         return false;
        //     }
        //     i++;
        //     j--;
        // }
        // return true;
    }
}
// @lc code=end

