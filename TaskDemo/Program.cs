using System.Diagnostics;

namespace TaskDemo;
class Program
{
    static void Main(string[] args)
    {
        var employee = new ShortEmployee();
        //   employee.Hello(20,"sumon");
        employee.Hello<int, string>(20, "sumon");
        var intArray = new int[] { 9, -5, -1, 0, 9 };
        var strArray = new string[] { "abc", "hello", "cBA" };
        Console.WriteLine(MathUtils.Minimum(intArray));
        Console.WriteLine(MathUtils.Minimum(strArray));
        Debug.Assert(MathUtils.Minimum(intArray) == -1);
        var points = new Point[]{
                             new Point(1,1),
                             new Point(3,9),
                             new Point(2,6),

                                  };

        Console.WriteLine(MathUtils.Minimum(points) == points[0]);

        Console.WriteLine("Hello, World!");
    }
}
