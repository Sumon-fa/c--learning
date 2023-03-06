namespace advance;
public class Product<k>
{




    public k Name { get; set; } = default(k);
    public int ID { get; set; }

    public Product(k name, int id)
    {
        Name = name;
        ID = id;
    }

    public int Pop() => 4;
}