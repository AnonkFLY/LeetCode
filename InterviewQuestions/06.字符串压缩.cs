using System.Text;

public class SolutionIQ6
{
    public string CompressString(string S)
    {
        if (S.Length == 0)
            return S;
        StringBuilder sb = new StringBuilder(S[0]);
        char temp = S[0];
        ushort num = 0;
        for (int i = 0; i < S.Length; ++i)
            if (temp == S[i])
                ++num;
            else
            {
                sb.Append(temp);
                temp = S[i];
                sb.Append(num);
                num = 1;
            }
        sb.Append(temp);
        sb.Append(num);
        return sb.Length < S.Length ? sb.ToString() : S;
    }
}