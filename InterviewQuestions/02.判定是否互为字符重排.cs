public class SolutionIQ2
{
    public bool CheckPermutation(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;
        int s1Value = 0;
        int s2Value = 0;
        sbyte[] table = new sbyte[26];
        for (int i = 0; i < s1.Length; ++i)
        {
            s1Value = s1[i] - 'a';
            s2Value = s2[i] - 'a';
            ++table[s1Value];
            --table[s2Value];
        }
        for (int i = 0; i < 26; ++i)
            if (table[i] != 0)
                return false;
        return true;
    }
}