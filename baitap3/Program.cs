using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float i1 = 2;
            float i2 = 5;
            float i3 = -3;
            double d1 = 2.0;
            double d2 = 5.0;
            double d3 = -0.5;

            float f1 = i1 + (i2 * i3);
            float f2 = i1 * (i2 + i3);
            float f3 = i1 / (i2 + i3);
            float f4 = i1 / i2 + i3;

            float f5 = 3 + 4 + 5 / 3 ;
            float f6 = (3 + 4 + 5) / 3;



            Console.WriteLine("{0} + ({1} * {2}) = {3}" ,i1,i2,i3,f1 );
            Console.WriteLine("{0} * ({1} + {2}) = {3}", i1, i2, i3, f2);
            Console.WriteLine("{0} / ({1} + {2}) = {3}", i1, i2, i3, f3);
            Console.WriteLine("{0} / {1} + {2} = {3}", i1, i2, i3, f4);
            Console.WriteLine("{0} + {1}+ {2} / {3} = {4} " ,3,4,5,3,f5);
            Console.WriteLine(("({0} + {1}+ {2}) / {3} = {4} ", 3,4,5,3,f6);



            Console.ReadKey();

        }
    }
}
