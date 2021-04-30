using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введите число.");
            int n = int.Parse(Console.ReadLine());
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res = res * i;
            }
            Console.WriteLine("Факториал заданого числа = " + res);
        }
    }
}
