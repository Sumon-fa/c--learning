namespace DemoLinq;
public static class EnumerableExtension
{

 public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Predicate<T> cond)
 {

  foreach (var item in source)
  {
   if (cond(item))
   {
    yield return item;
   }

  }

 }
}