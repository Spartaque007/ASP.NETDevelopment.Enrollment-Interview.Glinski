using Gliski.Utils;
using System;
using Xunit;
using Math = Gliski.Utils.Math;

namespace Glinki.Utils.Tests
{
    public class MathTests
    {
        [Theory]
        [InlineData(20, -15, 5)]
        [InlineData(15, 20, 5)]
        [InlineData(5, 5, 5)]
        [InlineData(1, 3, 1)]
        [InlineData(100, 100, 100)]
        public void GetGCD_Euclidean_Test(int x, int y, int expect)
        {
            long a = Math.GetGCDEuclidean(x, y);
            Assert.Equal(expect, a);
        }
        [Theory]
        [InlineData(20, -15, 5)]
        [InlineData(15, 20, 5)]
        [InlineData(5, 5, 5)]
        [InlineData(1, 3, 1)]
        [InlineData(100, 100, 100)]
        public void GetGCD_Test2(long x, long y, long expect)
        {
            long a = Math. GetGCDBinary(x, y);
            Assert.Equal(expect, a);
        }
    }
}
