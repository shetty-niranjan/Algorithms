using System;

namespace ConsoleApplication
{
    public class RecursionCountDown
    {
        public void Countdown(int i)
        {
            Console.WriteLine(i);
            
            // base case
            if (i <= 0) return;

            // recursive case
            Countdown(i - 1);
        }
    }
}
