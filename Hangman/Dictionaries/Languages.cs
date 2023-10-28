namespace BonusAssignments.Hangman.Dictionaries
{
    public enum GameLanguage
    {
        Swedish,
        English
    }
    public static class Languages
    {
        private static Dictionary<int, string> SwedishDictionary = new()
        {
                {0, "Chokladpudding" },
                {1, "Systemutvecklare" },
                {2, "Potatismos" },
                {3, "Tuple" },
                {4, "Kompetensutvecklingsmöjligheter" },
                {5, "Energieffektivisering" },
                {6, "Webbtillgänglighetsdirektivet" }
        };
        private static Dictionary<int, string> EnglishDictionary = new()
        {
                {0, "Professional" },
                {1, "Excel" },
                {2, "Recursive" },
                {3, "Tuple" },
                {4, "Floccinaucinihilipilification" },
                {5, "Tergiversation" },
                {6, "Uncopyrightable" }
        };
        private static GameLanguage Language;

        private static Random Rng = new Random();

        public static string GetRandomWordFromDictionary(GameLanguage language = GameLanguage.Swedish)
        {
            Language = language;
            return language == GameLanguage.Swedish ? SwedishDictionary[Rng.Next(0, SwedishDictionary.Count)] : EnglishDictionary[Rng.Next(0, EnglishDictionary.Count)];
        }
        public static bool AddWordToDictionary(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("You cannot add an empty word to the dictionary.");
                return false;
            }
            if (word.Contains(' ') || word.Contains(',') || word.Contains('.'))
            {
                Console.WriteLine("You cannot add multiple words into the dictionary");
                return false;
            }
            if ((Language == GameLanguage.Swedish && SwedishDictionary.ContainsValue(word)) || (Language == GameLanguage.English && EnglishDictionary.ContainsValue(word)))
            {
                Console.WriteLine("Word already exists in the dictionary!");
                return false;
            }
            if (Language == GameLanguage.Swedish)
            {
                SwedishDictionary.Add(SwedishDictionary.Count, word);
            }
            else
            {
                EnglishDictionary.Add(EnglishDictionary.Count, word);
            }
            Console.WriteLine("Word added to the dictionary");
            return true;
        }
    }
}
