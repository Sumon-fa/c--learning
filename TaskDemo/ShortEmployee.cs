namespace TaskDemo;
public class ShortEmployee
{


    public string FirstName { get; set; }
    public string LastName { get; set; }


    public void Hello<T, K>(T first, K second) where T : struct where K : class
    {
        // var k = new K();
        // var k = default(K);

        T t;

        Console.WriteLine($"{first} {second}");

    }

}