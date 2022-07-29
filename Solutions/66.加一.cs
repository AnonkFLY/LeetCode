/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 */

// @lc code=start
using System;

public class Solution66
{
    //72:60还不错 也可能太简单没人做
    public int[] PlusOne(int[] digits)
    {
        int i = digits.Length - 1;
        ++digits[i];
        while (i >= 0)
        {
            if (digits[i] < 10)
                break;
            digits[i] = 0;
            --i;
            if (i < 0)
                break;
            ++digits[i];
        }
        if (i < 0)
        {
            var result = new int[digits.Length+1];
            Array.Copy(digits,0,result,1,digits.Length);
            result[0] = 1;
            return result;
        }
        return digits;
    }
}
// @lc code=end

