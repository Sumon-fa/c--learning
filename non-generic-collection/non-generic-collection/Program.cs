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
            MyList.Add("sm");
            MyList.Add("t");
            MyList.Clear();
            foreach (string item in MyList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
