using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введите число.");
            int a = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 0; i <= a; i++)
            {
                s += i;
            }
            Console.WriteLine(s);

        }
    }
}
