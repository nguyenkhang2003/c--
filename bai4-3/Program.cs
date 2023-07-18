using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 2;
            Console.WriteLine("Moi ban nhap vao so nguyen a :");
            a = int .Parse(Console.ReadLine());
            a -= (b + 7);
            Console.WriteLine("a=a-(b+7)={0}", a,b);
            Console.ReadKey();
        }
    }
}
