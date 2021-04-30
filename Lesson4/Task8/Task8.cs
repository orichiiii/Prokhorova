using System;

namespace Task8
{
    class Task8
    {
        static void Main(string[] args)
        {
            //Вывести двумерный массив в консоль, чтобы элементы рассполагались в виде матрицы, 
            //негативные цифры не должны выводиться.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i,j] >=0 )
                    {
                        Console.Write($"{array[i, j]} \t");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
