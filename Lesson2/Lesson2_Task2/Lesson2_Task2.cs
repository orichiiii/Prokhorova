using System;

namespace Lesson2_Task2
{
    class Lesson2_Task2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Добро пожаловать в калькулятор!");
            Console.WriteLine("Введите, какую операцию хотите сделать:");
            @Console.WriteLine("Отнимание, прибавление, умножение, деление. \n");
            string[] fewStrings;
            float firstValue;
            float secondValue;
            while (true)
            {
                Console.Write("Введите пример в формате отними 3 от 5: ");
                string mathOperation = Console.ReadLine();
                fewStrings = mathOperation.Split(' ');
                if (float.TryParse(fewStrings[1], out firstValue) && float.TryParse(fewStrings[3], out secondValue ))
                    break;
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные.");
                }
            }
            switch (fewStrings[0].ToLower())
            {
                case "отними":
                    float subtraction = secondValue - firstValue;
                    Console.WriteLine($"Результат операции: {subtraction}");
                    break;
                case "прибавь":
                case "сложи":
                    float sum = secondValue + firstValue;
                    Console.WriteLine($"Результат операции: {sum}");
                    break;
                case "умножь":
                    float mult = secondValue * firstValue;
                    Console.WriteLine($"Результат операции: {mult}");
                    break;
                case "подели":
                    float division = firstValue - secondValue;
                    Console.WriteLine($"Результат операции: {division}");
                    break;
                default:
                        Console.WriteLine("Вы ввели неизвестную операцию.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
