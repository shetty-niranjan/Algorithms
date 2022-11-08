using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class LoopSum
    {
        public int Sum(IEnumerable<int> arr)
        {
            var total = 0;
            foreach (var x in arr)
            {
                total += x;
            }
            return total;
        }
    }
}
