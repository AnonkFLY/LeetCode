using System;
using SortingAlgorithm;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //手动智能补全模式 确信
            Console.WriteLine("This a algorithm project!");
            SortTest();
        }
        //闲的蛋疼写个简单的排序测试框架。。
        //冒泡+选择，我不能理解为什么选择排序慢这么多，但是在执行多次后Csharp的优化结果都差不多，不懂，后面有时间写一个Cpp的测试一下
        static void SortTest()
        {
            var bubbleSort = new BubbleSort();
            var selectionSort = new SelectionSort();
            var sortTest = new SortTest(bubbleSort, new int[] { 124, 54135, 6534, 7, 7456, 541, 5454, 6, 57345, 354, 736, 4 });
            sortTest.AddTestSortingAlgorithm<BubbleSort>(bubbleSort);
            sortTest.AddTestSortingAlgorithm<SelectionSort>(selectionSort);
            Console.Write(sortTest.Test());
        }
    }
}
