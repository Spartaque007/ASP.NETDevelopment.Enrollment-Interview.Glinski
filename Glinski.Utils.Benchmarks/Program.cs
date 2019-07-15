using BenchmarkDotNet.Running;

namespace Glinski.Utils.Benchmarks
{
    class Program
    {
        static void Main()
        {
            var summary = BenchmarkRunner.Run<GCDBenchmark>();
        }
    }
}

