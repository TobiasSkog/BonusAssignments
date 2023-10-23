namespace BonusAssignments.Searching
{
    public static class LinearSearch
    {
        public static int Search(List<int> list, int target)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
