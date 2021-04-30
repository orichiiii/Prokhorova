using System;

namespace Lesson2_Task3
{
    class Lesson2_task3
    {
        static void Main(string[] args)
        {
            /*Нужно удалить из строки лишние пробелы, изменить имя Гриша на Кирилл, и номер
            заказа ‘#123123’ удалить вместе с ненужными пробелами.
            Сама строка - ‘ Добрый день, Гриша, ваш заказ #123123 находится в
            обработке.’*/
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string someString = " Добрый день, Гриша, ваш заказ #123123 находится в обработке.";
            var newString = someString.Replace("Гриша", "Кирилл");
            var newString1 = newString.TrimStart(' ');
            var newString2 = newString1.Replace(" #123123", "");
            Console.WriteLine(newString2);
            Console.ReadKey();
        }
    }
}
