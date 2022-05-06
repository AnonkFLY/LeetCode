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
        private ISortable _unmistakableSort;
        private Stopwatch _stopwatch = new Stopwatch();

        public SortTest(ISortable unmistakableSort, int[] orginArray)
        {
            this._unmistakableSort = unmistakableSort ?? throw new System.NullReferenceException();
            _originArray = new List<int>(orginArray) ?? throw new System.NullReferenceException();
        }

        public void AddTestSortingAlgorithm<T>(T obj) where T : ISortable
        {
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
            var correctArray = _unmistakableSort.Sort(_originArray.ToArray());
            foreach (var item in _originArray)
            {
                stringBuilder.Append($"{item} ");
            }
            stringBuilder.Append("\nCorrect Array: ");
            foreach (var item in correctArray)
            {
                stringBuilder.Append($"{item} ");
            }
            stringBuilder.Append("\n");
            foreach (var item in _sorts)
            {
                var array = _originArray.ToArray();
                _stopwatch.Restart();
                item.sortable.Sort(array);
                _stopwatch.Stop();
                var correct = Enumerable.SequenceEqual(array, correctArray);
                stringBuilder.Append($"[{item.sortName}] correct is [{correct}] time spent [{_stopwatch.Elapsed}]\n");
            }
            return stringBuilder.ToString();
        }
    }
}