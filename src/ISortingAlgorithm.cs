namespace B3r3ch1tSortingBenchmark
{
    public interface ISortingAlgorithm
    {
        string Name { get; }
        int[] Sort(int[] input);
    }
}