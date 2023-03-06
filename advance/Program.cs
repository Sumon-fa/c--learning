namespace advance;
class Program
{

    static void Main(string[] args)
    {

        //anonymous type(class)
        var product = new { Name = "peter", ID = 1 };
        var newProduct = product with { Name = $"{product.Name}", ID = 2 };
        Console.WriteLine(newProduct.Name);
        Console.WriteLine(newProduct.ID);
        Console.WriteLine(product.ID);
        var p1 = new Product<string>("sss", 5);
        Console.WriteLine(p1.Name);

    }
}
