using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;  

            Console.WriteLine("Введите значение Х.");
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение У.");
            float y = float.Parse(Console.ReadLine());

            if (x > 0 && y > 0) 
            { 
                Console.WriteLine("Заданная точка принадлежит первой четверти системы координат.");
            }         
            else if (x < 0 && y > 0) 
            {
                Console.WriteLine("Заданая точка принадлежит второй четверти системы кординат.");
            }
            else if (x < 0 && y < 0) 
            {
                Console.WriteLine("Заданая точка принадлежит третей четверти системы координат");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Заданая точка принадлежит четвертой четверти системы координат");
            }
            else if (x == 0 || y == 0)
            {
                Console.WriteLine("Заданая точка находится на оси системы координат и не принадлежит к любой из четвертей.");
            }
        }
    }
}
