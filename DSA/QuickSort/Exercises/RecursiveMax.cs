public class RecursiveMax
{
    public static int Max(List<int> list)
    {
        //int max = nums[0];
        //for (int i = 1; i < nums.Count; i++)
        //{
        //    if (max < nums[i])
        //        max = nums[i];
        //}
        //return max;

        if (list.Count == 0)
            throw new ArgumentException(nameof(list));
        if (list.Count == 1)
            return list[0];

        var max = Max(list[1..]);
        return list[0] > max ? list[0] : max;
    }
}