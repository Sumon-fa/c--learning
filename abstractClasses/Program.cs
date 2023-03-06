namespace abstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Cube(3) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has volume {shape.Volume()} ");
                Cube iceCube = shape as Cube;
                if (shape is Cube)
                {
                    Console.WriteLine("it is a cube");
                }

            }
            object cube1 = new Cube(2);
            Cube cube2 = (Cube)cube1;
            Console.WriteLine(cube2.Volume());

        }
    }
}
