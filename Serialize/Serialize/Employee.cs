using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    [Serializable]
    internal class Employee
    {
        public string Name;
        public int Id;
        public Employee(string name,int id)
        {
            Name = name;
            Id = id;
        }
    }
}
