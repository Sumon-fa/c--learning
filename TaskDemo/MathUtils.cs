

public static class MathUtils
{
    public static T Minimum<T>(T[] items) where T : IComparable<T>
    {
        var min = items[0];
        foreach (var item in items)
        {
            // it will retun min number compare to item

            if (item.CompareTo(min) < 0)
            {
                min = item;
            }

        }
        Console.WriteLine(min);
        return min;
    }
}