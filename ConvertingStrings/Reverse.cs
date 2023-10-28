namespace BonusAssignments.ConvertingStrings
{
    public static class Reverse
    {
        public static string ReverseString(string word)
        {
            var reversedWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += $"{(i == word.Length - 1 ? word.ToUpper()[i] : word.ToLower()[i])}";
            }

            return reversedWord;
        }
    }
}
