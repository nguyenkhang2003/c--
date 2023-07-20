using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dtb;
            Console.WriteLine("moi nhap vao diem trung binh");
            dtb = float.Parse(Console.ReadLine());
            if (dtb >= 8)
                Console.WriteLine("xep loai gioi");
            else if (dtb >= 6.5 && dtb < 8)
                Console.WriteLine("xep lai kha");
            else if (dtb >= 5 && dtb <= 6.5)
                Console.WriteLine("xep loai trung binh");
            else
                Console.WriteLine("xep loai yeu");
            Console.ReadKey();
                

        }
    }
}
