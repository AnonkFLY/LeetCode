using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SortingAlgorithm
{
    //重新复习下基本排序算法
    public struct TestSortMethod
    {
        public ISortable sortable;
        public string sortName;

        public TestSortMethod(ISortable sortable, string sortName)
        {
            this.sortable = sortable;
            this.sortName = sortName;
        }
    }
    public class SortTest
    {
        private List<int> _originArray;
        private List<TestSortMethod> _sorts = new List<TestSortMethod>();
        private int[] _correctArray;
        private Stopwatch _stopwatch = new Stopwatch();

        public SortTest(int[] orginArray)
        {
            _originArray = new List<int>(orginArray) ?? throw new System.NullReferenceException();
        }

        public void AddTestSortingAlgorithm<T>() where T : ISortable, new()
        {
            var obj = new T();
            _sorts.Add(new TestSortMethod(obj, obj.GetType().ToString()));
        }
        public void ResetSortingAlgorithm()
        {
            _sorts.Clear();
        }
        /// <summary>
        /// Test the all algorithm
        /// </summary>
        public string Test()
        {
            StringBuilder stringBuilder = new StringBuilder("Orgin Array: ");
            foreach (var item in _originArray)
            {
                stringBuilder.Append($"{item} ");
            }
            stringBuilder.Append("\nCorrect Array: ");

            stringBuilder.Append("\n");
            foreach (var item in _sorts)
            {
                var array = _originArray.ToArray();
                _stopwatch.Restart();
                item.sortable.Sort(array);
                _stopwatch.Stop();
                if (_correctArray == null)
                {
                    _correctArray = array;
                    foreach (var num in _correctArray)
                    {
                        stringBuilder.Append($"{num} ");
                    }
                    stringBuilder.Append("\n");
                }
                var correct = Enumerable.SequenceEqual(array, _correctArray);
                stringBuilder.Append($"[{item.sortName}] correct is [{correct}] time spent [{_stopwatch.Elapsed}]");
                if (!correct)
                    foreach (var num in array)
                        stringBuilder.Append($"{num} ");
                stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
        }
    }
}