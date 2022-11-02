using Algorithms.CSharpAlgorithms;

Console.WriteLine("Binary Search!");
BinarySearch bs = new BinarySearch();
var myList = new List<int> { 1, 3, 5, 7, 9 };
Console.WriteLine(bs.Search(myList, 3)); // => 1
Console.WriteLine(bs.Search(myList, 9)); // => 4
Console.WriteLine(bs.Search(myList, 10)); //null gets printed as an empty string

