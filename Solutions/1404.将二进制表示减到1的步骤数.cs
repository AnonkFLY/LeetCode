using System;

public class Solution
{
    public int NumSteps(string s)
    {
        // 直接特殊处理
        if (s.Length < 3)
            return s.Length - 1;
        int step = 0;
        int start = 0;
        char[] array = s.ToCharArray();
        for (int i = array.Length - 1; i > 0;)
        {
            if (array[i] == '1')
            {
                start = i;
                while (array[start] == '1' && start > 0)
                {
                    array[start] = '0';
                    --start;
                }
                array[start] = '1';
                ++step;
            }
            if (array[i] == '0')
            {
                ++step;
                --i;
            }
        }
        return step + 1;
    }

    //1000111001101
    //1000111001110  +1  +1
    //100011100111  /2  +1
    //100011101000 +1 +1
    //100011101 /2 /2 /2 +3
    //100011110 +1 +1
    //10001111 /2 +1
    //10010000 +1 +1
    //1001 /2^4 +4
    //1010 +1 +1
    //101 /2 +1


}