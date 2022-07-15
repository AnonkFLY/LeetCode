using System;
using System.Collections.Generic;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        if (nums1.Length < 1)
            return nums1;
        if (nums2.Length < 1)
            return nums2;
        Array.Sort(nums1);
        Array.Sort(nums2);
        var tempN1 = nums1;
        var tempN2 = nums2;
        int n1 = 0;
        int n2 = 0;
        List<int> list = new List<int>();
        while (n1 < tempN1.Length && n2 < tempN2.Length)
        {
            if (tempN1[n1] == tempN2[n2])
            {
                list.Add(tempN1[n1]);
                ++n1;
                ++n2;
            }
            else if (tempN1[n1] > tempN2[n2])
                ++n2;
            else
                ++n1;
        }
        return list.ToArray();
    }
}