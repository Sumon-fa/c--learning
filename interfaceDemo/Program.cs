namespace interfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);

            Car car = new Car();
            car.Hours();
        }
    }
}