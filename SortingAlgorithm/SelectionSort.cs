namespace SortingAlgorithm
{
    public class SelectionSort : ISortable
    {
        public int[] Sort(int[] array)
        {
            int minIndex;
            for (int i = 0; i < array.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (i != minIndex)
                {
                    var temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
            return array;
        }
    }
}