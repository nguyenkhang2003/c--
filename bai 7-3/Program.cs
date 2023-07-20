using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tong, hieu;
            Console.WriteLine("Moi nhap vao tong 2 so:");
            tong=double.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap vao hieu 2 so:");
            hieu=double.Parse(Console.ReadLine());
            //cong thuc
            double x = (tong + hieu) / 2;
            double y = (tong - x);
            //ket qua
            Console.WriteLine("gia tri cua x la :" + x);
            Console.WriteLine("gia tru cua y la :" + y);
            Console.ReadKey();

        }
    }
}
