namespace BonusAssignments.Palindrome
{
    public static class PalindromeController
    {
        public static bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("The word entered was null or empty");
                return false;
            }
            var reversedWord = ConvertingStrings.Reverse.ReverseString(word);
            return reversedWord.ToLower() == word.ToLower();
        }
    }
}