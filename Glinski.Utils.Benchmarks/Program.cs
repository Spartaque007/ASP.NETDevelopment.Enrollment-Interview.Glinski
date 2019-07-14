using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Gliski.Utils;
using System.Numerics;

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

