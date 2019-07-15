using Xunit;
using Gliski.Utils;
using System;

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
        [InlineData("aeiou aeiou aeiou", 15)]
        public void CountOfVowels_Test(string text, int expect)
        {
            int a = StringCouter.CountOfVowels(text);
            Assert.Equal(expect, a);
        }

        [Theory]
        [InlineData
            (new string[] { "666666", "55555", "4444", "333", "22","1" },
            new string[] { "1", "22","333", "4444", "55555", "666666" })]
        [InlineData
            (new string[] { "1" },
            new string[] { "1" })]
        public void OrderStringsByLengthBubble_Test(string[] arrayIN, string[] arrayExpect)
        {
            string[] arrayAfterSort = StringCouter.OrderStringsByLengthBubble(arrayIN);
            Assert.Equal(arrayExpect, arrayAfterSort);
        }

        [Fact]
        public void OrderStringsByLengthBubble_ExceptionTest()
        {
            string[] arrayIn = new string[] { "666666", null};
            Assert.Throws<NullReferenceException>(()=>StringCouter.OrderStringsByLengthBubble(arrayIn));
            Assert.Throws<NullReferenceException>(()=>StringCouter.OrderStringsByLengthBubble(arrayIn));
        }

        
        [Theory]
        [InlineData
            (new string[] { "666666", "55555", "4444", "333", "22", "1" },
            new string[] { "1", "22", "333", "4444", "55555", "666666" })]
        [InlineData
            (new string[] { "1" },
            new string[] { "1" })]
        public void OrderStringsByLengthMerge_Test(string[] arrayIN, string[] arrayExpect)
        {
            string[] arrayAfterSort = StringCouter.OrderStringsByLengthMerge(arrayIN);
            Assert.Equal(arrayExpect, arrayAfterSort);
        }
    }
}
