using System;

public class SolutionIQ5
{
    public bool OneEditAway(string first, string second)
    {
        if (first.Length - second.Length > 1)
            return false;
        if (first.Length < second.Length)
            return OneEditAway(second, first);
        if (first == second)
            return true;
        int tolerance = 0;
        if (first.Length == second.Length)
        {
            for (int i = 0; i < first.Length; ++i)
                if (first[i] != second[i])
                    if (++tolerance >= 2)
                        return false;
        }
        else
        {
            for (int i = 0; i < second.Length;)
                if (first[i + tolerance] != second[i])
                {
                    if (++tolerance >= 2)
                        return false;
                }
                else
                    ++i;
        }
        return true;
    }

}