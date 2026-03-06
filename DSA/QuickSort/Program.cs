// Escreva o código para a função soma, vista anteriormente:
var arr = new int[] { 2, 4, 6 };
Console.WriteLine(RecursiveSum.Sum(arr));


// Escreva uma função recursiva que conte o número de itens em uma lista:
//var items = new List<int> { 7, 2, 3, 6, 10 };
var items = new List<string> { "Jose", "Pedro", "Azevedo" };
Console.WriteLine(RecursiveCount.Count(items));


// Encontre o valor mais alto em uma lista:
var list = new List<int> { 11, 2, 10, 4, 17, 12, 20, 6, 14 };
//var list = new List<int> { -10, -5, 0, -3, -7 };
//var list = new List<int>();
Console.WriteLine(RecursiveMax.Max(list));

// Recursive binary search:
var sortedList = new List<int> { 10, 20, 30, 40, 50 };
Console.WriteLine(RecursiveBinarySearch.BinarySearch(sortedList, 50, 0, sortedList.Count - 1));
