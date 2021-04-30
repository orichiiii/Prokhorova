using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3_Task8
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
            Console.WriteLine("\nВывод массива (смена первой и второй половины):");
            for (int i = myArray.Length / 2; i <= myArray.Length - 1; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            for (int a = 0; a < myArray.Length / 2; a++)
            {
                Console.WriteLine(myArray[a]);
            }
        }

    }
}
