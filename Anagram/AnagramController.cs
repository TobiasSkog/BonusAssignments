namespace BonusAssignments.Anagram
{
    public static class AnagramController
    {
        public static bool IsAnagram(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
            {
                return false;
            }
            firstWord = firstWord.ToUpper();
            secondWord = secondWord.ToUpper();
            for (int i = 0; i < firstWord.Length; i++)
            {
                if (ContainsLetter(firstWord, secondWord[i]))
                {
                    if (ContainsLetter(secondWord, firstWord[i]))
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ContainsLetter(string word, char c)
        {
            return word.Contains(c);
        }
    }
}
