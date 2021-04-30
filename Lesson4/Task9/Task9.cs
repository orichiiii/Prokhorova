using System;

namespace Task9
{
    class Task9
    {
        static void Main(string[] args)
        {
            do {
                /*Пользователь вводит строку и в ответ ему должно выводиться сколько слов, которые начинаются с 
                заглавной буквы находятся в предложении и также выводятся все эти слова через запятую. 
                Учесть, что таких слов может и не быть.*/
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.InputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine("Введите строку: \t");
                string StringFromConsole = Console.ReadLine();
                StringFromConsole = StringFromConsole.Replace(",", "");
                StringFromConsole = StringFromConsole.Replace(".", "");
                StringFromConsole = StringFromConsole.Replace("?", "");
                StringFromConsole = StringFromConsole.Replace(";", "");
                StringFromConsole = StringFromConsole.Replace("-", "");
                StringFromConsole = StringFromConsole.Replace(":", "");
                StringFromConsole = StringFromConsole.Replace("!", "");
                string[] stringArray = StringFromConsole.Split(' ');
                int number = 0;
                string RES = "";
                for (int i = 0; i < stringArray.Length; i++)
                {
                    if (stringArray[i].Length > 0 && Char.IsUpper(stringArray[i], 0))
                    {
                        number++;
                        RES += $"{stringArray[i]}, ";
                    }
                }
                if (number == 0)
                {
                    Console.WriteLine("В предложении нет слов, начинающихся с заглвной буквы.");
                }
                else
                {
                    RES.TrimEnd(' ').TrimEnd(',');
                    Console.WriteLine(RES);
                }
                Console.WriteLine("Press ESC for exit.");
            }while(Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
