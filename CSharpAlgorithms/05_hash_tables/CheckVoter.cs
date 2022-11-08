using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class CheckVoter
    {
        private static Dictionary<string, bool> _voted = new Dictionary<string, bool>();

        public void Voter(string name)
        {
            if (_voted.ContainsKey(name))
            {
                Console.WriteLine("kick them out!");
            }
            else
            {
                _voted.Add(name, true);
                Console.WriteLine("let them vote!");
            }
        }
    }
}
