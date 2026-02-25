internal class Program
{
    private static void Main(string[] args)
    {
        var list = new List<int> { 5, 3, 6, 2, 10, 1 };
        var sortedList = SelectionSort(list);
        foreach (var i in sortedList)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        var arr = new int[] { 5, 3, 6, 2, 10, 1 };
        var sortedArr = SelectionSort(arr);
        foreach (var i in sortedArr)
        {
            Console.Write(i + " ");
        }
    }

    static int FindSmallest(List<int> list)
    {
        var lowest = list[0];
        var smallestIndex = 0;

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] < lowest)
            {
                lowest = list[i];
                smallestIndex = i;
            }
        }

        return smallestIndex;
    }
    
    static int[] SelectionSort(List<int> arr)
    {
        var sortedArr = new int[arr.Count];
        
        for (int i = 0; i < sortedArr.Length; i++)
        {
            var smallestIndex = FindSmallest(arr);
            sortedArr[i] = arr[smallestIndex];
            arr.RemoveAt(smallestIndex);
        }

        return sortedArr;
    }

    static int[] SelectionSort(int[] arr)
    {
        // Laço para iterar sobre cada elemento do array.
        // Utilizamos o índice para marcar a posição em que
        // deve ser colocado o menor elemento encontrado
        for (int i = 0; i < arr.Length; i++)
        {
            var smallestIndex = i;

            // Laço para encontrar o menor elemento no array
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[smallestIndex])
                { 
                    smallestIndex = j;
                }
            }

            // Troca o elemento atual com o menor elemento encontrado
            (arr[i], arr[smallestIndex]) = (arr[smallestIndex], arr[i]);
        }

        return arr;
    }
}