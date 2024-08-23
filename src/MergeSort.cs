namespace B3r3ch1tSortingBenchmark;

public class MergeSort : ISortingAlgorithm
{
    public string Name => "Merge Sort";

    public int[] Sort(int[] input)
    {
        return SortArray(input);
    }

    private int[] SortArray(int[] input)
    {
        if (input.Length <= 1) return input;

        var mid = input.Length / 2;
        var left = SortArray(input.Take(mid).ToArray());
        var right = SortArray(input.Skip(mid).ToArray());

        return Merge(left, right);
    }

    private int[] Merge(int[] left, int[] right)
    {
        var result = new int[left.Length + right.Length];
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                result[k++] = left[i++];
            }
            else
            {
                result[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            result[k++] = left[i++];
        }

        while (j < right.Length)
        {
            result[k++] = right[j++];
        }

        return result;
    }
}