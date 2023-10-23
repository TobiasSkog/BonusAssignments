namespace BonusAssignments.Hangman.Objects
{
    public class Game
    {
        private string Word { get; set; }

        public Game()
        {
            Word = Dictionaries.Dictionaries.GetRandomWordFromDictionary();
        }
    }
}
