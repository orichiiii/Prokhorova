using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            float a, b, c;
            Console.WriteLine("Введите число 1.");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2.");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 3.");
            c = float.Parse(Console.ReadLine());

            float Result1 = a * b * c;
            float Result2 = a + b + c;

            if (Result1 > Result2)
            {
                Console.WriteLine("Ответ равен " + (Result1 + 3));
            }
            else if (Result1 < Result2)
            {
                Console.WriteLine("Ответ равен " + (Result2 + 3));
            }
        }
    }
}
