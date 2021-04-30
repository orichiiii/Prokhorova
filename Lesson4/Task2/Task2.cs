using System;

namespace Task2
{
    class Task2
    {
        static void Main()
        {
            //Разработать методы вывода фигур из ноликов
            //(квадрат, треугольник прямоугольный, треугольник равносторонний, перевернутые треугольники, песочные часы).
            var arrayTriangle = new int[,] { { 1, 1, 0, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0 } };
            var arrayClock = new int[,] { { 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 1 }, { 1, 1, 0, 1, 1 }, { 1, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0 } };
            var arraySquare = new int[,] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            var arrayInvertedTriangle = new int[,] { { 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 0, 1, 1 } };
            Figures(ref arrayTriangle);
            Figures(ref arrayInvertedTriangle);
            Figures(ref arraySquare);
            Figures(ref arrayClock);
            Triangle();
        }
        static void Figures(ref int[,] array)
        {
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    if (array[i, j] == 0)
                    {
                        Console.Write($"{array[i, j]}");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Triangle()
        {
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}
