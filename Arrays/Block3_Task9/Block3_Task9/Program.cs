using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3_Task9
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
            Console.WriteLine("\nВывод массива:");
            for (int i = 0; i < myArray.Length; i++)
                Console.WriteLine(myArray[i]);

            //Метод пузырька

            int c;
            for (int a = 0; a < elementsCount; a++) 
            {
                for (int i = 0; i < myArray.Length - 1; i++)
                {
                    if (myArray[i] > myArray[i + 1])
                    {
                        c = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = c;
                    }
                }       
            }
            Console.WriteLine("\nМассив в порядке возрастания: ");
            for (int i = 0; i < myArray.Length; i++)
            {

                Console.WriteLine(myArray[i] + " ");
            }
        }
    }
}
