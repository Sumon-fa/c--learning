namespace custom_interface;
class Program
{
    static void Main(string[] args)
    {
        DogShelter shelter = new DogShelter();
       
        foreach (Dog dog in shelter)
        {
            if (dog.IsNaughty)
            {
                dog.GiveTreat(2);
            }
            else
            {
                dog.GiveTreat(4);
            }

        }

        Console.WriteLine("Hello, World!");
    }
}
