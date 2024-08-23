namespace B3r3ch1tSortingBenchmark;

public class BenchmarkResult
{
    public string AlgorithmName { get; set; } = string.Empty;
    public long ElapsedMilliseconds { get; set; }
    public int[] SortedArray { get; set; } = [];
}