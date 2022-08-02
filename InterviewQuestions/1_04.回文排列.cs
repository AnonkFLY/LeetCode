using System.Collections.Generic;

public class SolutionIQ1_04
{
    public bool CanPermutePalindrome(string s)
    {
        HashSet<char> table = new HashSet<char>();
        for (int i = 0; i < s.Length; ++i)
            if (!table.Add(s[i]))
                table.Remove(s[i]);
        return table.Count <= 1;
    }
}