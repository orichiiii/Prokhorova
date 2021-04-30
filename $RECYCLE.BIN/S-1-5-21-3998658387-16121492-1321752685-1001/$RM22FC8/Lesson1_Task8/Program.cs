using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введите имя первого человека:");
            string personNamе1 = Console.ReadLine();
            float firstAge;
            while (true)
            {
                Console.WriteLine("Введите возраст первого человека:");
                string personAge1 = Console.ReadLine();
                if (float.TryParse(personAge1, out firstAge))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные.");
                }
            }
            Console.WriteLine("Введите имя второго человека:");
            string personName2 = Console.ReadLine();
            float secondAge;
            while (true)
            {
                Console.WriteLine("Введите возраст второго человека:");
                string personAge2 = Console.ReadLine();
                if (float.TryParse(personAge2, out secondAge))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректные данные.");
                }
            }
            string difference = "";
            if (firstAge > secondAge)
            {
                difference = personNamе1;
            }
            else if (firstAge < secondAge)
            {
                difference = personName2;
            }
            else
            {
                difference = "нет";
            }
            while (true)
            {
                Console.Write("Человек с каким, из двух введённых имён старше? Введите имя: ");
                string nameOlder = Console.ReadLine();
                if (int.TryParse(nameOlder, out int nameOldernum))
                {
                    Console.WriteLine("Вы ввели некорректные данные.");
                }
                else if (nameOlder != personNamе1 & nameOlder != personName2)
                {
                    Console.WriteLine($"Вы ввели некорректные данные. Выберите одно из двух имён: {personNamе1} или {personName2}");
                }
                else
                {
                    break;
                }
                if (nameOlder == difference)
                {
                    Console.WriteLine("Ответ правильный.");
                    Console.Write($"Старше {0}, разница в возрасте = {1} лет", difference, Math.Abs(firstAge - secondAge));
                }
                else
                {
                    Console.WriteLine("Ответ неправильный.");
                    Console.Write($"Старше {0}, разница в возрасте = {1} лет", difference, Math.Abs(firstAge - secondAge));
                }
                Console.ReadKey();
            }
        }
    }
}

