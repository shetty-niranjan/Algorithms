using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class GreedyAlgorithm
    {
        public void SetCovering(Dictionary<string, HashSet<string>> stations, HashSet<string> statesNeeded)
        {
            var finalStations = new HashSet<string>();
            while (statesNeeded.Any())
            {
                string? bestStation = string.Empty;
                var statesCovered = new HashSet<string>();
                foreach (var station in stations)
                {
                    var covered = new HashSet<string>(statesNeeded.Intersect(station.Value));
                    if (covered.Count > statesCovered.Count){
                        bestStation = station.Key;
                        statesCovered = covered;
                    }
                }
                statesNeeded.RemoveWhere(s => statesCovered.Contains(s));
                bool v = finalStations.Add(item: bestStation);
            }
            Console.WriteLine(string.Join(", ", finalStations));
        }
    }
}
