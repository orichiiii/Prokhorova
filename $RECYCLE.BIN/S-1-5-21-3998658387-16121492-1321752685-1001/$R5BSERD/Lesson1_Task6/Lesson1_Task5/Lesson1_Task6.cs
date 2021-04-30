using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task5
{
    class Lesson1_Task6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введите цену:");
            float price = float.Parse(Console.ReadLine());
            if (price > 0 & price <= 500)
                Console.WriteLine("Цена недостаточно высока для получения скидки");
            else if (price > 500 & price <= 1000)
            {
                float sale50 = price - 50;
                Console.WriteLine("Цена с учётом скидки " + sale50);
            }
            else if (price <= 0)
                Console.WriteLine("Вам нужно что-то приобрести, чтобы получить скидку");
            else
            {
                float sale100 = price - 100;
                Console.WriteLine("Цена с учётом скидки " + sale100);
                Console.ReadKey();
            }
        }
    }
}
