using System.Collections.Generic;
using System.Text;

public class Solution
{
    // public struct Data
    // {
    //     public string s;
    //     public int[] indices;
    //     public string[] sources;
    //     public string[] targets;
    // }
    public string FindReplaceString(string s, int[] indices, string[] sources, string[] targets)
    {
        StringBuilder sb = new StringBuilder();
        Dictionary<int, string[]> table = new Dictionary<int, string[]>();
        for (int i = 0; i < indices.Length; ++i)
        {
            if (table.ContainsKey(indices[i]))
                continue;
            var value = new string[2];
            value[0] = sources[i];
            value[1] = targets[i];
            table.Add(indices[i], value);
        }
        for (int i = 0; i < s.Length; ++i)
        {
            if (table.TryGetValue(i, out var str) && i + str[0].Length <= s.Length && s.Substring(i, str[0].Length) == str[0])
            {
                i += str[0].Length - 1;
                sb.Append(str[1]);
                continue;
            }
            sb.Append(s[i]);
        }
        return sb.ToString();
    }


}