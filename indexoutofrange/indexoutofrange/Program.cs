using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexoutofrange
{
    internal class Program
    {
        static void Main(string[] args)
        {


            StringBuilder sb = new StringBuilder("sumon");
            sb.Append("  fakir");
            sb.Append(" BD");
            Console.WriteLine(sb);




















            int[] arr = new int[3];
            try {
                arr[0] = 5;
                arr[1] = 6;
                arr[2] = 7;
                arr[3] = 9;
                foreach (int item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
          

            Console.ReadLine();

        }
    }
}
