using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введите количество элементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент массива под инлексом {i}:\t ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < myArray.Length; i++)
                Console.WriteLine(myArray[i]);
            int max = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            int indexMax = Array.IndexOf(myArray, max);
            Console.WriteLine($"Индекс максимального значения массива {indexMax}");
        }
    }
}
