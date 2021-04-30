using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введите число 1.");
            float FirstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2.");
            float SecondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 3.");
            float ThirdValue = float.Parse(Console.ReadLine());

            if (FirstValue > 0 & SecondValue > 0 & ThirdValue > 0)
            {
                Console.WriteLine("Сумма чисел равна " + (FirstValue + SecondValue + ThirdValue));
            }
            else if (FirstValue > 0 & SecondValue > 0 & ThirdValue <= 0)
            {
                Console.WriteLine("Сумма чисел равна " + (FirstValue + SecondValue));
            }
            else if (FirstValue > 0 & SecondValue <= 0 & ThirdValue > 0)
            {
                Console.WriteLine("Сумма чисел равна " + (FirstValue + ThirdValue));
            }
            else if (FirstValue <= 0 & SecondValue > 0 & ThirdValue > 0)
            {
                Console.WriteLine("Сумма чисел равна " + (SecondValue + ThirdValue));

            }
        }
    }
}
