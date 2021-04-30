using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3_Task9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCount];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент массива под инлексом {i}:\t ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < myArray.Length; i++)
                Console.WriteLine(myArray[i]);

            // метод выбора

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[j] < myArray[min])
                    {
                        min = j;
                    }
                }
                int temp = myArray[min];
                myArray[min] = myArray[i];
                myArray[i] = temp;
            }
            return;

        }
    }
}
