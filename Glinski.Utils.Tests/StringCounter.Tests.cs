using Xunit;
using Gliski.Utils;

namespace Glinki.Utils.Tests
{
    public class StringCounterTest
    {
        [Theory]
        [InlineData("eeee", 4)]
        [InlineData("a e i  v hv hj kll e/?\n", 4)]
        [InlineData("", 0)]
        [InlineData("ghjlkjрлпорало", 0)]
        [InlineData("aeiou", 5)]
        public void CountOfVowels_Test(string text, int expect)
        {
            int a = StringCouter.CountOfVowels(text);
            Assert.Equal(expect, a);
        }
    }
}
