namespace B3r3ch1tSortingBenchmark;

public class BubbleSort : ISortingAlgorithm
{
    public string Name => "Bubble Sort";

    public int[] Sort(int[] input)
    {
        var arr = (int[])input.Clone();
        for (var i = 0; i < arr.Length - 1; i++)
        {
            for (var j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] <= arr[j + 1]) continue;
                var temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
        return arr;
    }
}