/*
 * @lc app=leetcode.cn id=48 lang=csharp
 *
 * [48] 旋转图像
 */

// @lc code=start


public class Solution// : ITestable
{
    public void RotateIndex(int[][] matrix, int x, int y, int count)
    {

    }
    public void Rotate(int[][] matrix)
    {
        //Rotate
        int height = matrix.Length;
        for (int i = 0; i < height / 2; ++i)
        {
            int width = height - i - 1;
            for (int j = i; j < width; ++j)
            {
                int temp = matrix[i][j];
                int m = height - j - 1;
                matrix[i][j] = matrix[m][i];
                matrix[m][i] = matrix[width][m];
                matrix[width][m] = matrix[j][width];
                matrix[j][width] = temp;
            }
        }



        // int height = matrix.Length;
        // for (int i = 0; i < height / 2; ++i)
        // {
        //     for (int j = 0; j < height; ++j)
        //     {
        //         int temp = matrix[i][j];
        //         matrix[i][j] = matrix[height - 1 - i][j];
        //         matrix[height - 1 - i][j] = temp;
        //     }
        // }
        // for(int i =0;i<height;++i)
        // {
        //     for(int j = i+1;j<height;++j)
        //     {
        //         int temp = matrix[i][j];
        //         matrix[i][j] = matrix[j][i];
        //         matrix[j][i] = temp;
        //     }
        // }
        // PrintData(matrix);
    }

    // public void Test(object defaultData)
    // {
    //     Rotate((int[][])defaultData);
    // }

    // private void PrintData(int[][] matrix)
    // {
    //     for (int i = 0; i < matrix.Length; ++i)
    //     {
    //         for (int j = 0; j < matrix.Length; ++j)
    //         {
    //             Program.Print(matrix[i][j]);
    //         }
    //         Program.Print("\n");
    //     }
    //     Program.Print("++++++\n");
    // }
}
// @lc code=end

