using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitDemo
{
    class Person
    {
        public string Navn { get; init; }
    }

    static class Demo
    {
        public static void Test()
        {

            Person p1 = new Person { Navn = "Mikkel" };
            // p.Navn = "Mathias";  // Fejl

        }
    }
}
