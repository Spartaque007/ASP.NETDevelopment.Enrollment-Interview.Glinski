using Xunit;
using Gliski.Utils;
using Xunit.Abstractions;

namespace Glinki.Utils.Tests
{
    public class StringCounterTest
    {
        private readonly ITestOutputHelper output;
        public StringCounterTest(ITestOutputHelper output)
        {
            this.output = output;
        }

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
            (new string[] { "666666", "55555", "4444", "333", "22", "1" },
            new string[] { "1", "22", "333", "4444", "55555", "666666" })]
        [InlineData
            (new string[] { null, null, "4444", "333", "22", "1" },
            new string[] { "1", "22", "333", "4444", null, null })]
        [InlineData
            (new string[] { "1" },
            new string[] { "1" })]
        public void OrderStringsByLengthBubble_Test(string[] arrayIN, string[] arrayExpect)
        {
            string[] arrayAfterSort = StringCouter.OrderStringsByLengthBubble(arrayIN);
            Assert.Equal(arrayExpect, arrayAfterSort);
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


        [Theory]
        [InlineData("aaa aaa bb b uuuu bb", "aaa  bb b uuuu ")]
        [InlineData("", "")]
        [InlineData("11 11 11       11 11 11 11", "11            ")]
        [InlineData("DS::::::: ds DS DS", "DS::::::: ds  ")]
        [InlineData("12321312312", "12321312312")]
        [InlineData("   ", "   ")]
        [InlineData(",.-&?::;!fffffff,.-&?::;!fffffff,.-&?::;!fffffff",
            ",.-&?::;!fffffff,.-?::;!,.-?::;!")]

        public void RemoveDuplicateWords_Test(string text, string expectedText)
        {
            string stringAfterRemove = StringCouter.RemoveDuplicateWords2(text);
            Assert.Equal(expectedText, stringAfterRemove);
        }
    }
}
