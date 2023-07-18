using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string hoTen;
            float diemToan;
            float diemVan;
            Console.WriteLine("Moi ban nhap ho ten:");
            hoTen = Console.ReadLine();
            Console.WriteLine("Moi nhap vao diem Toan");
            diemToan =float.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap vao diem Van:");
            diemVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Hoc sinh {0} co diem toan la {1} ,diem van la {2}",hoTen, diemToan,diemVan);
            Console.ReadKey();


        }
    }
}
