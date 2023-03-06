using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
           
            myQueue.Enqueue(2);
            
            myQueue.Enqueue(3);
            myQueue.Dequeue();

            Console.WriteLine(myQueue.Peek());
        }
    }
}
