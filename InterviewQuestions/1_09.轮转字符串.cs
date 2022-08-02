public class SolutionIQ1_09
{
    public bool IsFlipedString(string s1, string s2)
    {
        return s1.Length == s2.Length && (s1 + s1).Contains(s2);
    }
}