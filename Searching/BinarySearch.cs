namespace BonusAssignments.Searching
{
    public static class BinarySearch
    {
        public static int Search(List<int> list, int target)
        {
            int low = 0, high = list.Count - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (list[mid] == target)
                {
                    return mid;
                }
                else
                {
                    if (target > list[mid])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
