using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task2
{
    class Lesson1_Task2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введите год:\t");
            int year = int.Parse(Console.ReadLine());
            if (year > 1000 & year <= 1100)
                Console.WriteLine("ХI столетие, II тысячелетие.");
            else if (year >= 0 & year <= 1000)
                Console.WriteLine("Введите 4-х значное число, больше 1000.");
            else if (year > 1000 & year <= 1200)
                Console.WriteLine("ХII столетие, II тысячелетие.");
            else if (year > 1200 & year <= 1300)
                Console.WriteLine("ХIII столетие, II тысячелетие.");
            else if (year > 1300 & year <= 1400)
                Console.WriteLine("ХIV столетие, II тысячелетие.");
            else if (year > 1400 & year <= 1500)
                Console.WriteLine("ХV столетие, II тысячелетие.");
            else if (year > 1500 & year <= 1600)
                Console.WriteLine("ХVI столетие, II тысячелетие.");
            else if (year > 1600 & year <= 1700)
                Console.WriteLine("ХVII столетие, II тысячелетие.");
            else if (year > 1700 & year <= 1800)
                Console.WriteLine("ХVIII столетие, II тысячелетие.");
            else if (year > 1800 & year <= 1900)
                Console.WriteLine("ХIX столетие, II тысячелетие.");
            else if (year > 1900 & year <= 2000)
                Console.WriteLine("ХX столетие, II тысячелетие.");
            else if (year > 2000 & year <= 2100)
                Console.WriteLine("ХXI столетие, III тысячелетие.");
            else
                Console.WriteLine("Будущее мне не подвластно.");
            Console.ReadKey();
        }
    }
}
