using Xunit;
using FluentAssertions;

namespace StringPermutations.Test
{
    public class Test
    {
        [Fact] public void ABC()
        {
            var all =  Permutations.Compute("abc").OrderBy(s => s);

            all.Should().BeEquivalentTo(new[]
            {
                "abc", "acb", "bac", "bca", "cab", "cba",
            });
        }

        [Fact] public void ABCD()
        {
            var all = Permutations.Compute("abcd").OrderBy(s => s);

            all.Should().BeEquivalentTo(new[]
            {
                "abcd",
                "abdc",
                "acbd",
                "acdb",
                "adbc",
                "adcb",
                "bacd",
                "badc",
                "bcad",
                "bcda",
                "bdac",
                "bdca",
                "cabd",
                "cadb",
                "cbad",
                "cbda",
                "cdab",
                "cdba",
                "dabc",
                "dacb",
                "dbac",
                "dbca",
                "dcab",
                "dcba",
            });
        }

    }
}
