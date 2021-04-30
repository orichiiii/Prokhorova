using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введите число 1");
            float a = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите число 2");
            float b = float.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Произведение чисел = " + a * b);
            }
            else
            {
                Console.WriteLine("Сумма чисел = " + (a + b));
            }
        }
    }
}
