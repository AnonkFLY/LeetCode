using System;
using SortingAlgorithm;

namespace LeetCode
{
    class Program
    {
        static int[] array = new int[] { 124, 54135, 6534, 7, 7456, 541, 5454, 6, 57345, 354, 736, 4 };//{1,4,5,7,3,2,8,6,9};//
        static void Main(string[] args)
        {
            //手动智能补全模式 确信
            Console.WriteLine("This a algorithm project!");
            new Test().TestAlgrothm(); 
            // Console.WriteLine("abcd".Substring(, 3));
            //SortTest();
        }

        public static void Print(object text)
        {
            Console.Write(text);
        }

        //闲的蛋疼写个简单的排序测试框架。。
        //冒泡+选择，我不能理解为什么选择排序慢这么多，但是在执行多次后Csharp的优化结果都差不多，不懂，后面有时间写一个Cpp的测试一下
        //2022-05-07 21:20:31 是因为在作为正确排序执行一次后的优化。解决方法:拿第一次执行的作为正确答案:所以应确保第一个排序算法总是正确的。
        //2022年6月13日 缓存命中应该是 和CSharp优化无关
        static void SortTest()
        {
            var bubbleSort = new BubbleSort();
            var selectionSort = new SelectionSort();
            var sortTest = new SortTest(array);
            sortTest.AddTestSortingAlgorithm<BubbleSort>();
            sortTest.AddTestSortingAlgorithm<SelectionSort>();
            sortTest.AddTestSortingAlgorithm<InsertionSort>();
            sortTest.AddTestSortingAlgorithm<ShellSort>();
            Console.Write(sortTest.Test());
        }
        //最后测试结果:2022年05月12日 11.30.09 
        // [SortingAlgorithm.BubbleSort] correct is [True] time spent [00:00:00.0002274]
        // [SortingAlgorithm.SelectionSort] correct is [True] time spent [00:00:00.0001267]
        // [SortingAlgorithm.InsertionSort] correct is [True] time spent [00:00:00.0000923]
        // [SortingAlgorithm.ShellSort] correct is [True] time spent [00:00:00.0000968]
    }
}
