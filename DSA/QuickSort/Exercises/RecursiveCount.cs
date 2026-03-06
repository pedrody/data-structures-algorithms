public class RecursiveCount
{
    public static int Count<T>(List<T> items)
    {
        if (items.Count == 0)
            return 0;
        if (items.Count == 1)
            return 1;

        return 1 + Count(items[1..]);
    }
}