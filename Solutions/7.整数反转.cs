public class Solution7
{
    public int Reverse(int x)
    {
        int result = 0;
        while (x != 0)
        {
            result = result * 10 + x % 10;
            x /= 10;
            if (result > int.MaxValue / 10 || result < int.MinValue / 10)
                return 0;
        }
        return result;
    }
}