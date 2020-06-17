using System;
using System.Linq;
using System.Text;

namespace Codesanook.Common {
    public static class RandomHelper {
        private static readonly Random random = new Random();

        public static string GenerateRandomCharacters(int randomLength) {
            // Create an array of characters to user for password reset.
            // Exclude confusing or ambiguous characters such as 1 0 l o i
            var characters = new[] {
                "2", "3", "4", "5", "6", "7", "8", "9",
                "a", "b", "c", "d", "e", "f", "g", "h", "j", "k", "m", "n",
                "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            var randomCharacters = new StringBuilder();
            Enumerable.Range(0, randomLength).Aggregate(randomCharacters, (accumulate, _) => {
                randomCharacters.Append(
                    characters[random.Next(characters.Length)]
                );
                return accumulate;
            });

            return randomCharacters.ToString();
        }
    }
}
