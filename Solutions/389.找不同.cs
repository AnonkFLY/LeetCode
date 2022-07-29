/*
 * @lc app=leetcode.cn id=389 lang=csharp
 *
 * [389] 找不同
 */

// @lc code=start
public class Solution389
{
    //tired -5.1
    public char FindTheDifference(string s, string t)
    {
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            sum += s[i];
            sum -= t[i];
        }
        sum -= t[t.Length - 1];
        return (char)-sum;
    }
}
// @lc code=end

