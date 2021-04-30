using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task6
{
    class Lesson1_Task4
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
                if (float.TryParse(personAge1, out  firstAge))
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
            string difference;
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
                difference = "Возраст этих людей одинаковый.";
            }
            string name = "";
            Console.WriteLine($"Человек с каким, из двух введённых имён старше, {personNamе1} или {personName2}?");
            Console.Write("Если возраст людей одинаковый, введите - нет: ");
            while (true)
            {
                Console.Write("Введите имя: ");
                string nameOlder = Console.ReadLine();
                if (int.TryParse(nameOlder, out int nameOldernum))
                {
                    Console.WriteLine("Вы ввели некорректные данные.");
                }
                else
                {
                    break;
                }
            }
            if (nameOlder == difference)
            {

            }
        }
    }
}
