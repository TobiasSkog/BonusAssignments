namespace BonusAssignments.Hangman.Logic
{
    internal class WordController
    {
        private string Word { get; }
        private List<char> HiddenWord { get; }
        private List<char> GuessedChars { get; }

        public WordController(string word)
        {
            Word = word;
            HiddenWord = HideWord();
            GuessedChars = new();
        }
        public int GetWordLength()
        {
            return Word.Length;
        }
        public bool IsGuessDuplicate(string guess)
        {
            var bigGuess = guess.ToUpper();
            var smallGuess = guess.ToLower();
            if (GuessedChars.Contains(bigGuess[0]) || GuessedChars.Contains(smallGuess[0]))
            {
                return true;
            }
            return false;
        }
        public bool UpdateGameStateString(string guess)
        {
            var bigGuess = guess.ToUpper();
            var smallGuess = guess.ToLower();
            var letterGuessed = false;

            GuessedChars.Add(smallGuess[0]);
            if (Word.Contains(bigGuess) || Word.Contains(smallGuess))
            {
                for (int i = 0; i < HiddenWord.Count; i++)
                {
                    if (Word[i] == bigGuess[0] || Word[i] == smallGuess[0])
                    {
                        HiddenWord[i] = i == 0 ? bigGuess[0] : smallGuess[0];
                        letterGuessed = true;
                    }
                }
            }

            return letterGuessed;
        }

        public string GetGuessedLetters()
        {
            return string.Join(" ", GuessedChars.Select(a => a.ToString()));
        }
        public bool HiddenWordContainsUnderscores()
        {
            return HiddenWord.Contains('_');
        }
        public string GetGameWord(int guessesMade)
        {
            if (guessesMade == 0)
            {
                return Word;
            }

            return string.Join(" ", HiddenWord.Select(a => a.ToString()));
        }

        private List<char> HideWord()
        {
            var hiddenWord = new List<char>();
            for (int i = 0; i < Word.Length; i++)
            {
                hiddenWord.Add('_');
            }
            return hiddenWord;
        }
    }
}
