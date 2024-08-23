using BenchmarkDotNet.Attributes;
using Bogus;

namespace B3r3ch1tSortingBenchmark
{
    [MemoryDiagnoser]
    public class SortingBenchmarks
    {
        private int[] _data = [];

        [GlobalSetup]
        public void Setup()
        {
            // Use Bogus to generate an array of random integers.
            var faker = new Faker();
            _data = Enumerable.Range(1, 1000)
                .Select(_ => faker.Random.Int(1, 10000000))
                .ToArray();
        }

        [Benchmark]
        public int[] BubbleSortBenchmark() => new BubbleSort().Sort(_data);

        [Benchmark]
        public int[] MergeSortBenchmark() => new MergeSort().Sort(_data);

        [Benchmark]
        public int[] QuickSortBenchmark() => new QuickSort().Sort(_data);
    }
}