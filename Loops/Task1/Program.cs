using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;
            int evenNumbersSum = 0;
            int currentValue = 1;
            int limit = 99;
            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum = evenNumbersSum + currentValue;
                }
                else
                {
                    oddNumbersCount++;
                }
                currentValue++;
            }
                Console.WriteLine("Количество чётных чисел " + evenNumbersCount);
                Console.WriteLine("Сумма чётных чисел " + evenNumbersSum);        
        }
    }
}
