using System;
/*
 * @lc app=leetcode.cn id=121 lang=csharp
 *
 * [121] 买卖股票的最佳时机
 */

// @lc code=start
public class Solution121
{
    public int MaxProfit(int[] prices)
    {
        //贪心
        var value = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i + 1] > prices[i])
                value += prices[i + 1] - prices[i];
        }
        return value;
    }
}
// @lc code=end

