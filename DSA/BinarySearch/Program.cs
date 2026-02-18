List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine(BinarySearch(myList, 5));
Console.WriteLine(BinarySearch(myList, 3));
Console.WriteLine(BinarySearch(myList, -1));

int? BinarySearch(List<int> list, int item)
{
    int low = 0;
    int high = list.Count - 1;
    
    while (low <= high)
    {
        int mid = (low + high) / 2;
        int guess = list[mid];

        if (guess == item) return mid;
        else if (guess > item) high = mid - 1;
        else low = mid + 1;
    }

    return null;
}