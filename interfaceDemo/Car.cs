using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace interfaceDemo
{
    class Car
    {

        public void Hours()
        {
            Ticket ticket3 = new Ticket(3);
            Console.WriteLine(ticket3.DurationInHours);
        }

    }
}
