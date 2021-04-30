using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task3
{
    class Lesson1_Task3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введите число 1: ");
            float val1 = float.Parse(Console.ReadLine());
            Console.Write("Введите число 2: ");
            float val2 = float.Parse(Console.ReadLine());
            Console.Write("Введите число 3: ");
            float val3 = float.Parse(Console.ReadLine());
            if (val1 > val2 && val1 > val3)
                Console.WriteLine("\nНаибольшее значение имеет число " + val1);
            else if (val2 > val1 && val2 > val3)
                Console.WriteLine("\nНаибольшее значение имеет число " + val2);
            else if (val3 > val1 && val3 > val2)
                Console.WriteLine("\nНаибольшее значение имеет число " + val3);
            else if (val1 == val2 && val2 > val3)
                Console.WriteLine("\nНаибольшее значение имеет число " + val2);
            else if (val3 == val1 && val3 > val2)
                Console.WriteLine("\nНаибольшее значение имеет число " + val3);
            else if (val3 == val2 && val3 > val1)
                Console.WriteLine("\nНаибольшее значение имеет число " + val3);
            else
                Console.WriteLine("\nВсе числа равны.");
            Console.ReadKey();
        }
    }
}
