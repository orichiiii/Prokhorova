using System;

namespace Lesson3
{
    class Task1
    {
        static void Main(string[] args)
        {
            // Вывести все элементы массива используя все виды циклов.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int[] myArray = new int[5] { 2, 5, 7, 13, 24 };
            int index = 0;
            do
            {
                Console.WriteLine(myArray[index]);
                index++;
            } while (index < myArray.Length);

            while (index < myArray.Length)
            {
                Console.WriteLine(myArray[index]);
                index++;
            }

            for (int b = 0; b < myArray.Length; b++)
            {
                Console.WriteLine(myArray[b]);
            }

            foreach (var value in myArray)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
