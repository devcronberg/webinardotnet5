using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsDemo2
{
    static class Demo
    {
        public static void Test()
        {
            // Nyt i C# 9
            Person p1 = new("Mathias", 14);
            Person p2 = new("Mathias", 14);
            Console.WriteLine(p1 == p2);  // true
            Console.WriteLine(ReferenceEquals(p1, p2)); // false
            Console.WriteLine(p1);      // Person { Navn = Mathias, Alder = 14 }
            var (n, a) = p1;
            Console.WriteLine(n);       // Mathias
            Console.WriteLine(a);       // 14

        }
    }

    record Person(string Navn, int Alder);
}
