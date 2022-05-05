/*
 * @lc app=leetcode.cn id=509 lang=csharp
 *
 * [509] 斐波那契数
 */

// @lc code=start
public class Solution509
{
    //刚回家咕咕咕，预计下半个月尝试中等题目并进一步学习数据结构与算法
    //昨天直接鸽了
    public int Fib(int n)
    {
        //直接动规。。效果很差
        if (n <= 1)
            return n;
        int[] numbers = new int[n + 1];
        numbers[0] = 0;
        numbers[1] = 1;

        for (int i = 2; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i-1]+numbers[i-2];
        }
        return numbers[n];
        // int[] numbers = new int[3] { 0, 1, 1 };
        // if (n <= 2)
        //     return numbers[n];
        // int[] indexs = new int[3] { 0, 1, 2 };
        // int start = 0;
        // while (n - start > 2)
        // {
        //     //2 1 0
        //     numbers[indexs[0]] = numbers[indexs[1]] + numbers[indexs[2]];
        //     int temp = indexs[0];
        //     indexs[0] = indexs[2];
        //     indexs[2] = temp;
        //     start++;
        // }
        // return numbers[indexs[2]];
    }
}
// @lc code=end

