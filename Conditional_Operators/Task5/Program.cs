using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введите рейтинговую оценку студента.");
            float a = float.Parse(Console.ReadLine());

            if (a > 0 & a < 19)
            {
                Console.WriteLine("Оценка студента F");
            }
            else if (a > 20 & a < 39)
            {
                Console.WriteLine("Оценка студента Е");
            }
            else if (a > 40 & a < 59)
            {
                Console.WriteLine("Оценка студента D");
            }
            else if (a > 60 & a < 74)
            {
                Console.WriteLine("Оценка студента C");
            }
            else if (a > 75 & a < 89)
            {
                Console.WriteLine("Оценка студента B");
            }
            else if (a > 90 & a < 100)
            {
                Console.WriteLine("Оценка студента A");
            }
        }
    }
}
