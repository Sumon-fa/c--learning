using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multiThread
{
    internal class Program
    {

        public  static void Method1()
        {
            for(int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Fun1: " + i);
            }
        }
        public static void Method2()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Fun2: " + i);
                if (i == 25)
                {
                    Console.WriteLine("sleep hgffhggggggggggggggg 2");
                    Thread.Sleep(4000);
                }
            }
        }
        public static void Method3()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Fun3: " + i);
            }
        }
        static Guid g = Guid.NewGuid();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            Thread t3 = new Thread(Method3);
            /* t1.Start();
             t2.Start();
             t3.Start();*/
            //   Console.WriteLine(g.ToString().Replace("-",String.Empty));
          //  Console.WriteLine(g.ToString("N").Substring(0,15));


        }
    }
}
