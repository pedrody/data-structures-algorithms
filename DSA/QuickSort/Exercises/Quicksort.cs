public class Quicksort
{
    public static IEnumerable<int> Qsort(IEnumerable<int> list)
    {
        if (list.Count() < 2) return list;

        var pivot = list.First();

        var less = list.Skip(1).Where(x => x <= pivot);
        var greater = list.Skip(1).Where(x => x > pivot);

        return Qsort(less).Concat(new List<int> { pivot }).Concat(Qsort(greater));
    }
}
