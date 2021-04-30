using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int del = 0; 
            Console.WriteLine("Введите число.");
            int n = int.Parse(Console.ReadLine());

            if (n <= 1) 
                Console.WriteLine("Число должно быть больше 1.");
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        del++;
                }

                if (del > 2)
                    Console.WriteLine("Это число сложное.");
                else
                    Console.WriteLine("Это простое число");
            }
        }
    }
}
