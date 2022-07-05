namespace SortingAlgorithm
{
    public class ShellSort : ISortable
    {
        //希尔排序根据插入排序优化--from https://www.runoob.com/cprogramming/c-sort-algorithm.html
        // 插入排序在对几乎已经排好序的数据操作时，效率高，即可以达到线性排序的效率
        // 但插入排序一般来说是低效的，因为插入排序每次只能将数据移动一位
        // 几乎排好的数据->进行分段大概排序
        // 低效->大概排序是指分块交换排序
        public int[] Sort(int[] array)
        {
            int i, j, gap, temp;
            for (gap = array.Length >> 1; gap > 0; gap >>= 1)
            {
                //和插入排序类似
                //i(length:20): 9..19,4..19,2..19,1..19,0..19
                #region 分块的插入排序
                for (i = gap; i < array.Length; i++)
                {
                    temp = array[i];
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                        array[j] = array[j - gap];
                    array[j] = temp;
                }
                #endregion
            }
            return array;
        }
    }
}