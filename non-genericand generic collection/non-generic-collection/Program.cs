using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace non_generic_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList MyArrayList = new ArrayList();
            List<string> MyList = new List<string>();
            MyArrayList.Add("1");
            MyArrayList.Add(80);


            MyList.Add("sm");
            MyList.Add("t");
            foreach (var item in MyArrayList)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
            foreach (string item in MyList)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
            MyList.Clear();

        }
    }
}
