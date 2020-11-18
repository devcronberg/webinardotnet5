using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsMathDemo
{
    static class Demo
    {
        public static void Test()
        {

            int antal = 30;

            if (antal > 24 && antal < 40)
                Console.WriteLine("*");     // *

            // =>

            if (antal is > 24 and < 40)
                Console.WriteLine("*");     // *

            // eller hvad med
            Console.WriteLine(antal switch
            {
                < 25 => "Mindre end 25",
                > 25 and < 40 => "Mellem 25 og 40",
                > 40 => "Større end 40"
            });


        }
    }


}
