public interface IMyList<T>
{
    // Check if the list contains a value
    bool Contains(T value);

    // Filter the values using a condition
    T[] Filter(Predicate<T> cond);

    // Transform the items of the list
    K[] Map<K>(Func<T, K> map);

    // Loop the items and do something
    void ForEach(Action<T> action);

    // Find first item in the list
    T FindFirst(T value);

    // Find last item in the list
    T FindLast(T value);

    // Return the first item that satisfies the condition or default value otherwise
    T FirstOrDefault(Predicate<T> cond);
}