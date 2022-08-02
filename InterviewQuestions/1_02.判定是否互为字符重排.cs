public class SolutionIQ1_02
{
    public bool CheckPermutation(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;
        sbyte[] table = new sbyte[26];
        for (int i = 0; i < s1.Length; ++i)
        {
            ++table[s1[i] - 'a'];
            --table[s2[i] - 'a'];
        }
        for (int i = 0; i < 26; ++i)
            if (table[i] != 0)
                return false;
        return true;
    }
}