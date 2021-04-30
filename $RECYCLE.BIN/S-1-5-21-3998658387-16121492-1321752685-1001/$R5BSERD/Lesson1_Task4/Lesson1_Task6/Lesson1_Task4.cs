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
            //Получить название дня недели исходя из введенной даты(пример вводимой даты 11.12.2012), 
            //введенная дата не может быть ранее 01.01.0001 и больше текущего дня. 

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введите дату: ");
            string value = Console.ReadLine();
            var inputDate = DateTime.Parse(value); 
            if (inputDate <= DateTime.Now) 
                Console.WriteLine(inputDate.ToString("dddd")); 
            else
                Console.WriteLine("Введенная дата не может быть в будущем");
            Console.ReadKey();
        }
    }
}
