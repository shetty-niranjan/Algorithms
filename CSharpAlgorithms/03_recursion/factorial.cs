using System;

namespace ConsoleApplication
{
    public class RecursionFactorial
    {
        public int Fact(int x)
        {
            if (x <= 1) return 1;

            return x * Fact(x - 1);
        }
    }
}
