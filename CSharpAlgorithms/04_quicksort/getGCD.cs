using System;
using System.Collections.Generic;
using System.Linq;

namespace GCD
{
    public class GCD
    {

        //Get great Comman Divisor
        public int GetGCD(int FirstNumber, int SecondNumber)
            => SecondNumber == default ? FirstNumber : GetGCD(SecondNumber, FirstNumber % SecondNumber);

        //Get great Comman Divisor of list
        public int GetGCDList(List<int> lst)
        {
            var result = lst[0];
            result = GetGCD(result, lst.Skip(1).FirstOrDefault());
            return result;
        }
    }
}