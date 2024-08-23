namespace B3r3ch1tSortingBenchmark;

public class QuickSort : ISortingAlgorithm
{
    public string Name => "Quick Sort";

    public int[] Sort(int[] input)
    {
        var arr = (int[])input.Clone();
        QuickSortRecursive(arr, 0, arr.Length - 1);
        return arr;
    }

    private void QuickSortRecursive(int[] arr, int low, int high)
    {
        if (low < high)
        {
            var pivotIndex = Partition(arr, low, high);
            QuickSortRecursive(arr, low, pivotIndex - 1);
            QuickSortRecursive(arr, pivotIndex + 1, high);
        }
    }

    private int Partition(int[] arr, int low, int high)
    {
        var pivot = arr[high];
        var i = (low - 1);

        for (var j = low; j < high; j++)
        {
            if (arr[j] >= pivot) continue;
            i++;
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        var temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }
}