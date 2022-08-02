using System;

public class SolutionIQ1_03
{
    public string ReplaceSpaces(string S, int length)
    {
        // readonly wnm!
        // 2022年7月26日 转char数组再试试
        // S[outLength] = S[i];
        // 面向API算法
        // return S.Substring(0, length).Replace(" ", "%20");
        int outLength = length - 1;
        for (int i = 0; i < length; ++i)
            if (S[i] == ' ')
                outLength += 2;
        var data = S.Substring(0, outLength + 1).ToCharArray();
        for (int i = length - 1; i >= 0; --i, --outLength)
        {
            if (data[i] != ' ')
                data[outLength] = data[i];
            else
            {
                data[outLength] = '0';
                data[--outLength] = '2';
                data[--outLength] = '%';
            }
        }
        return new string(data);
    }
}