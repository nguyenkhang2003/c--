using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            double pi= 3.14;
            double chuvi;
            double dientich;
            Console.WriteLine("Nhap r :");
            r= double.Parse(Console.ReadLine());
            chuvi = 2 * r * pi;
            dientich = pi * (r*r);
            Console.WriteLine("Chu vi cua hinh tron la : {0}", chuvi);
            Console.WriteLine("dien tich cua hinh tron la : {0}", dientich);
            Console.ReadKey();

            
            
        }
    }
}
