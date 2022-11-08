using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class RecursiveCount
    {
        public int Count(IEnumerable<int> list)
        {
            if(!list.Any()) return 0;

            return 1 + Count(list.Skip(1));
        }
    }
}
