using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class DiijkstrasAlgorithm
    {
        private const double _infinity = double.PositiveInfinity;
        private static Dictionary<string, Dictionary<string, double>> _graph = new Dictionary<string, Dictionary<string, double>>();
        private static List<string> _processed = new List<string>();

        public string FindLowestCostNode(Dictionary<string, double> costs)
        {
            var lowestCost = double.PositiveInfinity;
            string? lowestCostNode = string.Empty;
            foreach (var node in costs)
            {
                var cost = node.Value;
                if (cost < lowestCost && !_processed.Contains(node.Key))
                {
                    lowestCost = cost;
                    lowestCostNode = node.Key;
                }
            }
            return lowestCostNode;
        }
    }
}
