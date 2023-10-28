namespace BonusAssignments.Hangman.Logic
{
    internal class GameLogic
    {
        private WordController Controller { get; set; }
        private int CursorTopAdjustment { get; set; }
        private string IllegalCharacters { get; set; }
        private int GuessesRemaining { get; set; }
        public GameLogic(string illegalCharacters = "1234567890!\"#¤%&/()=?`^*'¨.-,;:_<>|@£$€{[]}\\")
        {
            Controller = new WordController(Dictionaries.Languages.GetRandomWordFromDictionary(Dictionaries.GameLanguage.Swedish));
            GuessesRemaining = 7;
            CursorTopAdjustment = 10;
            IllegalCharacters = illegalCharacters;
        }
        public void Guess()
        {
            do
            {
                Console.Write("\nMake a guess: ");
                var userGuess = Console.ReadLine();
                if (string.IsNullOrEmpty(userGuess) || userGuess.Length > 1 || IllegalCharacters.Contains(userGuess))
                {
                    ClearText("Invalid input! Please enter just one letter!");
                }
                else if (Controller.IsGuessDuplicate(userGuess))
                {
                    ClearText($"You already guessed \"{userGuess}\"");
                }
                else
                {
                    GuessesRemaining = Controller.UpdateGameStateString(userGuess) ? GuessesRemaining : (GuessesRemaining - 1);
                    break;
                }

            } while (true);

        }
        private void ClearText(string prompt)
        {
            Console.SetCursorPosition(0, CursorTopAdjustment);
            Console.Write(new string(' ', Console.WindowWidth * (Console.WindowHeight - CursorTopAdjustment)));
            Console.SetCursorPosition(0, CursorTopAdjustment);
            Console.WriteLine(prompt);
        }
        public void DrawGame()
        {
            Console.Clear();

            switch (GuessesRemaining)
            {
                case 7:
                    Console.WriteLine("  ______");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");
                    break;
                case 6:
                    Console.WriteLine("  ______");
                    Console.WriteLine(" |     |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");

                    break;
                case 5:
                    Console.WriteLine("  ______");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");

                    break;
                case 4:
                    Console.WriteLine("  ______");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine(" |     |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");

                    break;
                case 3:
                    Console.WriteLine("  ______");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine("/|     |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");

                    break;
                case 2:
                    Console.WriteLine("  ______");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine("/|\\    |");
                    Console.WriteLine("       |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");

                    break;
                case 1:
                    Console.WriteLine("  ______");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine("/|\\    |");
                    Console.WriteLine("/      |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");

                    break;
                case 0:
                    Console.WriteLine("  ______");
                    Console.WriteLine(" |     |");
                    Console.WriteLine(" O     |");
                    Console.WriteLine("/|\\    |");
                    Console.WriteLine("/ \\    |");
                    Console.WriteLine("       |");
                    Console.WriteLine("===========");

                    break;
            }
            Console.WriteLine($"Guessed letters: {Controller.GetGuessedLetters()}");
            Console.WriteLine(Controller.GetGameWord(GuessesRemaining));
        }
        public bool IsGameOver()
        {
            return !(GuessesRemaining == 0 || Controller.HiddenWordContainsUnderscores());
        }
        public void EndGame()
        {
            Console.WriteLine($"{(GuessesRemaining > 0 ?
                "You won!"
                :
                $"Game Over!\nThe word was: {Controller.GetGameWord(GuessesRemaining)}")}");
        }
    }
}

