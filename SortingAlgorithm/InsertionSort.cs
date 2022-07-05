using System;

namespace SortingAlgorithm
{
    public class InsertionSort : ISortable
    {
        //从前面遍历，遍历:作为最小的插入在前面
        public int[] Sort(int[] array)
        {
            int i, j, temp;
            for (i = 1; i < array.Length; i++)
            {
                temp = array[i];
                //往后找，找到一个比自己小的或者到头就结束
                for (j = i; j > 0 && array[j - 1] > temp; j--)
                {
                    array[j] = array[j - 1];
                }
                array[j] = temp;
            }
            return array;
        }
    }
}