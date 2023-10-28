using System.Text;

namespace ValidationUtility
{
    public class CharValidationHelper
    {
        public static char GetSpecificChar(string prompt, string allowedCharacters)
        {
            var chars = allowedCharacters.ToCharArray();
            while (true)
            {
                Console.Write(prompt);
                if (char.TryParse(Console.ReadLine().ToUpper(), out char validChar))
                {
                    if (chars.Contains(validChar))
                    {
                        return validChar;
                    }
                }
                Console.Write("\nYou must choose between (");
                for (int i = 0; i < chars.Length; i++)
                {

                    Console.Write($"{chars[i]}");
                    if (i == chars.Length - 1)
                    {
                        Console.Write(")\n");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

            }
        }
        public static string CharPasswordCreator(string prompt, bool showHiddenOutput)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string userInput = "";
            Console.Write(prompt);

            while (true)
            {

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    userInput += key.KeyChar;
                    if (showHiddenOutput)
                    {
                        Console.Write((char)2534);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && userInput.Length > 0)
                    {
                        userInput = userInput.Substring(0, (userInput.Length - 1));
                        if (showHiddenOutput)
                        {
                            Console.Write("\b \b");
                        }
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        if (string.IsNullOrEmpty(userInput))
                        {
                            Console.WriteLine("\nEmpty value not allowed.");
                            userInput = "";
                        }
                        else
                        {
                            return userInput;
                        }
                    }
                }
            }
        }

    }
}