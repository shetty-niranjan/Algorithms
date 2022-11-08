using Algorithms.CSharpAlgorithms;

Console.WriteLine("Binary Search!");
BinarySearch bs = new BinarySearch();
var myList = new List<int> { 1, 3, 5, 7, 9 };
Console.WriteLine(bs.Search(myList, 3)); // => 1
Console.WriteLine(bs.Search(myList, 9)); // => 4
Console.WriteLine(bs.Search(myList, 10)); //null gets printed as an empty string

//BFS
//private static Dictionary<string, string[]> _graph = new Dictionary<string, string[]>();
    // _graph.Add("you", new[] { "alice", "bob", "claire" });
    //         _graph.Add("bob", new[] { "anuj", "peggy" });
    //         _graph.Add("alice", new[] { "peggy" });
    //         _graph.Add("claire", new[] { "thom", "jonny" });
    //         _graph.Add("anuj", Array.Empty<string>());
    //         _graph.Add("peggy", Array.Empty<string>());
    //         _graph.Add("thom", Array.Empty<string>());
    //         _graph.Add("jonny", Array.Empty<string>());
    //         Search("you");

//Diijkstras Algo
//  _graph.Add("start", new Dictionary<string, double>());
//             _graph["start"].Add("a", 6.0);
//             _graph["start"].Add("b", 2.0);

//             _graph.Add("a", new Dictionary<string, double>());
//             _graph["a"].Add("fin", 1.0);

//             _graph.Add("b", new Dictionary<string, double>());
//             _graph["b"].Add("a", 3.0);
//             _graph["b"].Add("fin", 5.0);

//             _graph.Add("fin", new Dictionary<string, double>());

//             var costs = new Dictionary<string, double>();
//             costs.Add("a", 6.0);
//             costs.Add("b", 2.0);
//             costs.Add("fin", _infinity);

//             var parents = new Dictionary<string, string>();
//             parents.Add("a", "start");
//             parents.Add("b", "start");
//             parents.Add("fin", null);

//             var node = FindLowestCostNode(costs);
//             while (node != null)
//             {
//                 var cost = costs[node];
//                 var neighbors = _graph[node];
//                 foreach (var n in neighbors.Keys)
//                 {
//                     var new_cost = cost + neighbors[n];
//                     if (costs[n] > new_cost)
//                     {
//                         costs[n] = new_cost;
//                         parents[n] = node;
//                     }
//                 }
//                 _processed.Add(node);
//                 node = FindLowestCostNode(costs);
//             }
//             Console.WriteLine(string.Join(", ", costs));

//Greedy Algorithm
//   var statesNeeded = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
//             var stations = new Dictionary<string, HashSet<string>>();
//             stations.Add("kone", new HashSet<string> { "id", "nv", "ut" });
//             stations.Add("ktwo", new HashSet<string> { "wa", "id", "mt" });
//             stations.Add("kthree", new HashSet<string> { "or", "nv", "ca" });
//             stations.Add("kfour", new HashSet<string> { "nv", "ut" });
//             stations.Add("kfive", new HashSet<string> { "ca", "az" });
//             var finalStations = new HashSet<string>();


//Greedy Algorithm
//  var statesNeeded = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
//             var stations = new Dictionary<string, HashSet<string>>();
//             stations.Add("kone", new HashSet<string> { "id", "nv", "ut" });
//             stations.Add("ktwo", new HashSet<string> { "wa", "id", "mt" });
//             stations.Add("kthree", new HashSet<string> { "or", "nv", "ca" });
//             stations.Add("kfour", new HashSet<string> { "nv", "ut" });
//             stations.Add("kfive", new HashSet<string> { "ca", "az" });