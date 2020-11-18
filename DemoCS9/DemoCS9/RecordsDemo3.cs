using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsDemo4
{
    static class Demo
    {
        public static void Test()
        {

            Person p1 = new("Mikkel", 17, "DK");
            Console.WriteLine(p1);  // Person { Navn = Mikkel, Alder = 17, Land = DK }
            Person p2 = p1 with { Land = "SE" };
            Console.WriteLine(p2);  // Person { Navn = Mikkel, Alder = 17, Land = SE }


        }
    }

    record Person(string Navn, int Alder, string Land);
}
