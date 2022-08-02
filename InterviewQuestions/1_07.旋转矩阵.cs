public class SolutionIQ1_07
{
    public void Rotate(int[][] matrix)
    {
        int n = matrix.Length;
        for (int x = 0; x < matrix.Length / 2; ++x)
        {
            int length = n - x - 1;
            for (int y = x; y < length; ++y)
            {
                int temp = matrix[x][y];
                matrix[x][y] = matrix[n - y - 1][x];
                matrix[n - y - 1][x] = matrix[length][n - y - 1];
                matrix[length][n - y - 1] = matrix[y][length];
                matrix[y][length] = temp;
            }
        }
    }

}