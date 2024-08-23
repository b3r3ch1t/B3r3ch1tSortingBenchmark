using BenchmarkDotNet.Running;

namespace B3r3ch1tSortingBenchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SortingBenchmarks>();

            Console.ReadLine(); 
        }
    }
}
