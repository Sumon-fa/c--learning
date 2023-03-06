namespace custom_interface;

class Dog
{
    public string Name { get; set; }

    public bool IsNaughty { get; set; }

    public Dog(string name, bool isNaughty)
    {
        Name = name;
        IsNaughty = isNaughty;
    }
    public void GiveTreat(int numberOfTreat)
    {
        Console.WriteLine($"Dog name {Name} get {numberOfTreat} times food.");
    }
}