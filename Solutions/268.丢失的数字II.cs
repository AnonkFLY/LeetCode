using System;

public class Solution268
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);
        int length = nums.Length;
        int i = 0;
        while (i < length)
        {
            if (nums[i] != i)
                return i;
            ++i;
        }
        return length;
    }

}