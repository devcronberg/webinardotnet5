using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsDemo1
{
    static class Demo
    {
        public static void Test()
        {
            // Som i gamle dage
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

    class Person : IEquatable<Person>
    {
        public string Navn { get; init; }
        public int Alder { get; init; }
            
        public Person(string navn, int alder)
        {
            this.Navn = navn;
            this.Alder = alder;
        }

        public void Deconstruct(out string navn, out int alder)
        {
            navn = this.Navn;
            alder = this.Alder;
        }

        public override string ToString()
        {
            return $"Person {{ Navn = {this.Navn}, Alder = {this.Alder} }}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   Navn == other.Navn &&
                   Alder == other.Alder;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Navn, Alder);
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}
