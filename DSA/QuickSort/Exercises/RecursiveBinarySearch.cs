public class RecursiveBinarySearch
{
    public static int BinarySearch(List<int> list, int target, int low, int high)
    {
        if (low > high) return -1;

        var mid = (high + low) / 2;
        
        if (target == list[mid]) return mid;
        
        var targetIndex = target > list[mid] ? 
            BinarySearch(list, target, mid + 1, high) :
            BinarySearch(list, target, low, mid - 1);

        return targetIndex;
    }
}
