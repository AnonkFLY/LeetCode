public class Solution
{
    public bool IsUnique(string astr)
    {
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