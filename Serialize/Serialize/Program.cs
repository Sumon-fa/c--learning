using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string path = @"C:\Users\fakir\OneDrive\Desktop\project\demo\Sample.txt";
              Employee employee = new Employee("sumon", 1);
              FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
              BinaryFormatter bf = new BinaryFormatter();
              bf.Serialize(stream, employee);
              stream.Close();*/
            string path = @"C:\Users\fakir\OneDrive\Desktop\project\demo\Sample.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Employee emp = (Employee)bf.Deserialize( stream);
            Console.WriteLine(emp.Name);

        }
    }
}
