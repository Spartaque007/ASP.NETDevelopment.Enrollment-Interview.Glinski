using Gliski.Utils;
using System;
using Xunit;
using Math = Gliski.Utils.Math;

namespace Glinki.Utils.Tests
{
    public class MathTests
    {
        [Theory]
        [InlineData(20, 15, 5)]
        [InlineData(15, 20, 5)]
        [InlineData(5, 5, 5)]
        [InlineData(1, 3, 1)]
        [InlineData(100, 100, 100)]
        public void GetGCD_Test(int x, int y, int expect)
        {
            int a =Math.GetGCD(x, y);
            Assert.Equal(expect, a);
        }
        [Fact]
        public void GetGCD_Test_ExpectedException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => Math.GetGCD(0, 5));
        }
    }
}
