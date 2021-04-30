using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task7
{
    class Lesson1_Task7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введите значение: ");
            var val = Console.ReadLine();
            if (int.TryParse(val, out int s))
                Console.WriteLine("Вероятно, вы ввели значение типа int");
            else if (double.TryParse(val, out double i))
                Console.WriteLine("Вероятно, вы ввели значение типа double.");
            else if (char.TryParse(val, out char b))
                Console.WriteLine("Вероятно, вы ввели значение типа char");
            else if (bool.TryParse(val, out bool h))
                Console.WriteLine("Вероятно, вы ввели значение типа bool");
            else
                Console.WriteLine("Тип введённых данных неизвестен или вы ввели данные типа string.");
            Console.ReadKey();
        }
    }
}
