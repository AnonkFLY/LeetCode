using System.Collections.Generic;

public class Solution54
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        if (matrix.Length == 1)
            return matrix[0];
        sbyte[][] direction = new sbyte[4][]{
            new sbyte[]{0,1},
            new sbyte[]{1,0},
            new sbyte[]{0,-1},
            new sbyte[]{-1,0},
        };
        int dir = 0;
        sbyte index = 0;
        int m = matrix.Length;
        int n = matrix[0].Length;
        sbyte i = 0, j = 0;
        int[] result = new int[m * n];

        do
        {
            result[index] = matrix[i][j];
            matrix[i][j] = 1000;
            int x = i + direction[dir][0];
            int y = j + direction[dir][1];
            if (x >= m || y >= n || x < 0 || y < 0 || matrix[x][y] == 1000)
                dir = ++dir % 4;
            i += direction[dir][0];
            j += direction[dir][1];
        } while (++index < m * n);
        return result;
    }

}