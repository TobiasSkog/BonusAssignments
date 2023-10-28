namespace BonusAssignments.VowelsAndConsonantsCounter
{
    internal static class Counter
    {
        private static readonly string Vowels = "AEIOUYÅÄÖ";
        public static void CountVowelsAndConsonants(string word)
        {
            var vowelCount = 0;
            var consonantCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word.ToUpper()[i]))
                {
                    if (Vowels.Contains(word.ToUpper()[i]))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }

            Console.WriteLine($"The word \"{word}\" contains {vowelCount} vowels and {consonantCount} consonants.");
        }
    }
}