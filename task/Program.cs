namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cars = new Car();

            Console.WriteLine(cars.Contains(1));
            var filterCar = cars.Filter(x => x == 2);
            foreach (var item in filterCar)

            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            int[] carItems = cars.Map<int>(Mapping);
            foreach (int item in carItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            cars.ForEach(Mapp);
            Console.WriteLine("\n");
            Console.WriteLine(cars.FindFirst(1));
            Console.WriteLine("\n");
            Console.WriteLine(cars.FindLast(1));
            Console.WriteLine("\n");
            Console.WriteLine(cars.FirstOrDefault(x => x == 0));
        }
        static int Mapping(int s)
        {
            return s;
        }
        static void Mapp(int s)
        {
            Console.WriteLine(s);
        }

    }
}