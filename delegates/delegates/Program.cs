using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int[] numbers = { 1, 2, 3, 4, 5 };

                var squares = numbers.Select(x => x);

                foreach (int square in squares)
                {
                    Console.WriteLine(square);
                }

                Console.ReadKey();
            
        }
    }
}
