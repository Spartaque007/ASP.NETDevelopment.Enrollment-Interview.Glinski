using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Gliski.Utils;
using System.Numerics;

namespace Glinski.Utils.Benchmarks
{
    public class GCDBenchmark
    {


        [Params(int.MaxValue - 100, uint.MaxValue, long.MaxValue)]
        public long A { get; set; }

        [Params(int.MaxValue-100, uint.MaxValue, long.MaxValue)]
        public long B { get; set; }

        [Benchmark]
        public long EucldeanLong() => Math.GetGCDEuclidean(A, B);

        [Benchmark]
        public long Binary() => Math.GetGCDBinary(A, B);

        [Benchmark]
        public BigInteger SYS() => BigInteger.GreatestCommonDivisor(A, B);

        [Benchmark]
        public BigInteger BigIntegerEuclidean() => Math.GetGCDEuclidean(A, B);
    }


}
