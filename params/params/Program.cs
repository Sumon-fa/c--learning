using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 4;
            ParamMethod(x,y);
        }

        public static  void ParamMethod(params object[]sentence)
        {
foreach(object item in sentence)
            {
                Console.WriteLine(item+"6");
            }
        }
    }
}
