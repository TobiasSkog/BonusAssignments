using BonusAssignments.Hangman.Logic;
namespace BonusAssignments.Hangman
{
    public class Game
    {

        private GameLogic Logic { get; set; }
        public Game()
        {
            Console.Clear();
            Logic = new GameLogic();
        }

        public void PlayGame()
        {
            Logic.DrawGame();

            while (!Logic.IsGameOver())
            {
                Logic.DrawGame();
                Logic.Guess();
            }

            Logic.EndGame();

            Console.WriteLine();

            if (ValidationUtility.BoolValidationHelper.PromptForYesOrNo("Play again: "))
            {
                Logic = new GameLogic();
                PlayGame();
            }
        }
    }
}
