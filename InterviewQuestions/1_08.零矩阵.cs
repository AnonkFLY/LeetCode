using System.Collections.Generic;

public class SolutionIQ1_08
{
    public void SetZeroes(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;
        bool flag = false;
        for (int i = 0; i < m; ++i)
        {
            if (matrix[i][0] == 0)
                flag = true;
            for (int j = 1; j < n; ++j)
                if (matrix[i][j] == 0)
                    matrix[i][0] = matrix[0][j] = 0;
        }
        for(int i = m-1;i>=0;--i){
            for(int j = 1;j<n;++j)
                if(matrix[i][0]==0||matrix[0][j]==0)
                    matrix[i][j] = 0;
            if(flag)
                matrix[i][0] = 0;
        }
        #region  还行，但是空间复杂度高了
        // if (matrix.Length <= 0)
        //     return;
        // int xL = matrix.Length;
        // int yL = matrix[0].Length;
        // HashSet<int> xRecord = new HashSet<int>();
        // HashSet<int> yRecord = new HashSet<int>();
        // for (int i = 0; i < xL; ++i)
        // {
        //     for (int j = 0; j < yL; ++j)
        //     {
        //         if (matrix[i][j] == 0)
        //         {
        //             xRecord.Add(i);
        //             yRecord.Add(j);
        //         }
        //     }
        // }
        // foreach (var item in xRecord)
        // {
        //     for (int i = 0; i < yL; ++i)
        //     {
        //         matrix[item][i] = 0;
        //     }
        // }
        // foreach (var item in yRecord)
        // {
        //     for (int i = 0; i < xL; ++i)
        //     {
        //         matrix[i][item] = 0;
        //     }
        // }
        # endregion
    }
}