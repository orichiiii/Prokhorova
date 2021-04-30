using System;

namespace Task6
{
    class Task6
    {
        static void Main(string[] args)
        {
            // Вывести сумму всех чисел двумерного массива, нужно использовать циклы.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };
            int sum = 0;
            foreach (var value in array)
            {
                sum += value;
            }
            Console.WriteLine(sum);
        }
    }
}
