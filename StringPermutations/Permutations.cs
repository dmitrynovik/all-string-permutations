using System.Collections.Generic;
using System.Text;

namespace StringPermutations
{
    public static class Permutations
    {
        public static IEnumerable<string> Compute(string s) => 
            string.IsNullOrEmpty(s) ? new[] { s } : Compute(new StringBuilder(s));

        public static IEnumerable<string> Compute(StringBuilder s, int start = 0)
        {
            if ((start + 1) >= s.Length)
                return new[] { s.ToString() };


            var results = new List<string>() { s.ToString() };
            for (var i = start; i < s.Length; ++i)
            {
                for (int j = i + 1; j < s.Length; ++j)
                {
                    Swap(s, i, j);
                    var tail = Compute(s, i + 1);
                    results.AddRange(tail);
                    Swap(s, i, j);
                }
            }

            return results;
        }

        private static void Swap(StringBuilder s, int i, int j) => (s[j], s[i]) = (s[i], s[j]);
    }
}