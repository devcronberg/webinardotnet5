using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsDemo3
{
    static class Demo
    {
        public static void Test()
        {

            Person p1 = new() { Navn = "Mikkel", Alder = 17, Land = "DK" };
            p1.Gem();
            Console.WriteLine(p1);  // Person { Navn = Mikkel, Alder = 17, Land = DK }

            Person p2 = new() { Navn = "Mikkel", Alder = 17, Land = "DK" };
            Console.WriteLine(p1 == p2);    // true


        }
    }

    record Person(string Navn, int Alder)
    {

        public string Land { get; init; }

        public Person() : this(default, default)
        { }

        public void Gem()
        {
            // kode
        }
    }
}
