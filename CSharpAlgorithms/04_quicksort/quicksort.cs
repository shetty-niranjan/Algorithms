using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class QuckSort
    {
        public IEnumerable<int> Sort(IEnumerable<int> list)
        {
            if (list.Count() <= 1) return list;
            var pivot = list.First();
            var less = list.Skip(1).Where(i => i <= pivot);
            var greater = list.Skip(1).Where(i => i > pivot);
            return Sort(less).Union(new List<int> { pivot }).Union(Sort(greater));
        }
    }
}
