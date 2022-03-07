using System.Text;

namespace StringPermutations
{
    public static class Permutations
    {
        public static IEnumerable<string> Compute(string s) => 
            string.IsNullOrEmpty(s) ? new[] { s } : Compute(new StringBuilder(s));

        public static IEnumerable<string> Compute(StringBuilder s, int start = 0)
        {
            yield return s.ToString();

            if ((start + 1) >= s.Length)
                yield break;


            for (var i = start; i < s.Length; ++i)
            {
                for (int j = i + 1; j < s.Length; ++j)
                {
                    Swap(s, i, j);

                    foreach (var tail in Compute(s, i + 1))
                        yield return tail;

                    Swap(s, i, j);
                }
            }
        }

        private static void Swap(StringBuilder s, int i, int j) => (s[j], s[i]) = (s[i], s[j]);
    }
}