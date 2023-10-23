namespace BonusAssignments.Hangman.Dictionaries
{
    public static class Dictionaries
    {
        public static string GetRandomWordFromDictionary()
        {
            var english = new Dictionary<int, string>()
            {
                {0, "Professional" },
                {1, "Excel" },
                {2, "Recursive" },
                {3, "Tuple" },
                {4, "Floccinaucinihilipilification" },
                {5, "Tergiversation" },
                {6, "Uncopyrightable" }
            };

            var rng = new Random();
            var index = rng.Next(0, english.Count);
            return english[index];
        }
    }
}
