public class RecursiveSum
{
    public static int Sum(int[] arr)
    {
        if (arr.Length == 0)
            return 0;

        if (arr.Length == 1)
            return arr[0];

        return arr[0] + Sum(arr[1..]);
    }
}