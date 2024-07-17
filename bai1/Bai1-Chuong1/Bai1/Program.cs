using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
        
    {
        static void Main(string[] args)
        {
            int a, b, c, d, tich;
            Console.WriteLine("Nhap a: ");
            //a = int.Parse(Console.ReadLine());
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap d: ");
            d = int.Parse(Console.ReadLine());
            tich = d * c * b * a;
            Console.WriteLine($"Tich cua bon so: {tich}");

        }
    }
}
