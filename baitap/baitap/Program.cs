using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string name;
            int year;

            Console.Write("Nhập tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            year = Convert.ToInt32(Console.ReadLine());
            int hientai = DateTime.Today.Year;
            int tuoi = hientai - year;
            Console.WriteLine($"Xin chào {name} - {tuoi}");
            Console.ReadLine();
        }
    }
}
