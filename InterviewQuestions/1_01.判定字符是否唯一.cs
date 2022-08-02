public class SolutionIQ1_01
{
    public bool IsUnique(string astr)
    {
        // 原题是限制在26位小写字母，优解是 使用一个32位数据用1位去储存一个字母
        if (astr.Length > 26)
            return false;
        // int length = astr.Length;
        // for (int i = 0; i < length - 1; ++i)
        //     for (int j = i + 1; j < length; ++j)
        //         if (astr[i] == astr[j])
        //             return false;
        // return true;
        byte[] hash = new byte[26];
        for (int i = 0; i < astr.Length; ++i)
        {
            if(++hash[astr[i]-'a']>=2)
                return false;
        }
        return true;
    }
}