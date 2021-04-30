using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lesson1_Task1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; Console.InputEncoding = System.Text.Encoding.Unicode;
            int temp;
            Console.WriteLine("Введите температуру: ");
            temp = int.Parse(Console.ReadLine());
            if (temp >= -20 & temp <= 5)
                Console.WriteLine("Xолодно");
            else if (temp >= 6 & temp <= 15)
                Console.WriteLine("Прохладно");
            else if (temp >= 16 & temp <= 20)
                Console.WriteLine("Тепло");
            else if (temp >= 21 & temp <= 35)
                Console.WriteLine("Жарко");
            else if (temp >= 36 & temp <= 45)
                Console.WriteLine("Очень жарко");
            else 
                Console.WriteLine("НЕ ВЕРЮ! нет таких температур)))");
            Console.ReadKey();
        }
    }
}
