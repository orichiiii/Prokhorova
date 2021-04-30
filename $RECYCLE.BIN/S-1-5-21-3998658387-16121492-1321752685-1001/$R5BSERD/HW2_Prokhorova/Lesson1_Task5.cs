using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task4
{
    class Lesson1_Task5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введите число, которое хотите поделить: ");
            float val1 = float.Parse(Console.ReadLine());
            Console.Write("Введите число, на которое хотите поделить: ");
            float val2 = float.Parse(Console.ReadLine());
            if (val2 == 0)
                Console.WriteLine("На ноль делить нельзя!");
            else
            {
                float val3 = val1 % val2;
                Console.WriteLine("\nОстаток от деления этих чисел = " + val3 );
            }
            Console.ReadKey();
        }
    }
}
