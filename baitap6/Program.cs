using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double s;
            double p;
            Console.WriteLine("Nhap chieu dai a : " );
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong b :" );
            b= double.Parse(Console.ReadLine());
            s = a * b;
            p = (a +b) *2;
            Console.WriteLine("Dien tich hinh chu nhat la {0} ", s);
            Console.WriteLine("Chu vi hinh chu nhat la {0}", p);
            Console.ReadKey();



        }
    }
}
