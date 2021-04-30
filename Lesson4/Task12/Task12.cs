using System;

namespace Task12
{
    class Task12
    {
        static void Main(string[] args)
        {
            /*Создать двумерный массив 5х5.Заполнить рандомными значениями от 0 до 20.НЕ показывать пользоветелю. 
            Спрашивать по одному числу у пользователя, если введенное число есть в массиве*/
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            var array = new int[,] { { 1, 20, 19, 14, 4 }, { 7, 10, 19, 1, 7 }, { 2, 6, 4, 14, 3 }, { 9, 7, 8, 4, 10}, {3, 15, 4, 9, 20 } };
            do
            {
                Console.Write("Введите число от 0 до 20: ");
                int value = int.Parse(Console.ReadLine());
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (array[i, j] == value)
                        {
                            Console.Write($"{array[i, j]} ");
                        }
                        else
                        {
                            Console.Write("* ");
                        }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Нажмите Esc для выхода. Для продолжения нажмите Enter.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.ReadKey();

        }
    }
}
