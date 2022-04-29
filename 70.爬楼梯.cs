/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */

// @lc code=start
public class Solution70
{
    //动规入门题
    public int ClimbStairs(int n)
    {
        if (n < 3)
            return n;
        var stairs = new int[n];
        stairs[0] = 1;
        stairs[1] = 2;
        for(int i=2;i<n;i++)
        {
            stairs[i]=stairs[i-1]+stairs[i-2];
        }
        return stairs[n-1];
    }
}
// @lc code=end

