using System.Collections.Generic;

static class ExtendIList
{
    public static bool ContainsTwo<T>(this IList<T> list, T item)
    {
        int counter = 0;
        foreach (var i in list)
        {
            if (item.Equals(i))
            {
                counter++;
                if (counter == 2)
                {
                    return true;
                }
            }
        }
        return false;
    }
}