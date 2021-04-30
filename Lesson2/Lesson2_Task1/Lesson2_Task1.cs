using System;

namespace Lesson2_Task1
{
    class Lesson2_Task1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Ведите дату в формате: двадцать первое марта 1999-го года");
            string date4 = Console.ReadLine();
            string[] fewStrings = date4.Split(' ');
            string day = string.Empty;
            string day2 = string.Empty;
            string month = string.Empty;
            if (fewStrings.Length == 5)
            {
                switch (fewStrings[0].ToLower())
                {
                    case "двадцать":
                        day = "2";
                        break;
                    case "тридцать":
                        day = "3";
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректные данные");
                        break;
                }
                switch (fewStrings[1].ToLower())
                {
                    case "первое": day2 = "1"; break;
                    case "второе": day2 = "2"; break;
                    case "третье": day2 = "3"; break;
                    case "четвертое": day2 = "4"; break;
                    case "пятое": day2 = "5"; break;
                    case "шестое": day2 = "6"; break;
                    case "седьмое": day2 = "7"; break;
                    case "восьмое": day2 = "8"; break;
                    case "девятое": day2 = "9"; break;
                    default: break;
                }
                switch (fewStrings[2].ToLower())
                {
                    case "января": month = "01"; break;
                    case "февраля": month = "02"; break;
                    case "марта": month = "03"; break;
                    case "апреля": month = "04"; break;
                    case "мая": month = "05"; break;
                    case "июня": month = "06"; break;
                    case "июля": month = "07"; break;
                    case "августа": month = "08"; break;
                    case "сентября": month = "09"; break;
                    case "октября": month = "10"; break;
                    case "ноября": month = "11"; break;
                    case "декабря": month = "12"; break;
                    default: break;
                }
                string year = fewStrings[3].Substring(0, 4);
                Console.WriteLine($"{day}{day2}.{month}.{year}");
            }
            else
            {
                switch (fewStrings[0].ToLower())
                {
                    case "первое": day2 = "01";  break;
                    case "второе": day2 = "02"; break;
                    case "третье": day2 = "03"; break;
                    case "четвертое": day2 = "04"; break;
                    case "пятое": day2 = "05"; break;
                    case "шестое": day2 = "06"; break;
                    case "седьмое": day2 = "07"; break;
                    case "восьмое": day2 = "08"; break;
                    case "девятое": day2 = "09"; break;
                    case "десятое": day2 = "10"; break;
                    case "одинадцатое": day2 = "11"; break;
                    case "двенадцатое": day2 = "12"; break;
                    case "тринадцатое": day2 = "13"; break;
                    case "четырнадцатое": day2 = "14"; break;
                    case "пятнадцатое": day2 = "15"; break;
                    case "шеснадцатое": day2 = "16"; break;
                    case "семнадцатое": day2 = "17"; break;
                    case "восемнадцатое": day2 = "18"; break;
                    case "девятнадцатое": day2 = "19"; break;
                    case "двадцатое": day2 = "20"; break;
                    case "тридцатое": day2 = "21"; break;
                    default:
                        Console.WriteLine("Вы ввели некорректные данные");
                        break;
                }
                switch (fewStrings[1].ToLower())
                {
                    case "января": month = "01"; break;
                    case "февраля": month = "02"; break;
                    case "марта": month = "03"; break;
                    case "апреля": month = "04"; break;
                    case "мая": month = "05"; break;
                    case "июня": month = "06"; break;
                    case "июля": month = "07"; break;
                    case "августа": month = "08"; break;
                    case "сентября": month = "09"; break;
                    case "октября": month = "10"; break;
                    case "ноября": month = "11"; break;
                    case "декабря": month = "12"; break;
                    default: break;
                }
                string year = fewStrings[2].Substring(0, 4);
                Console.WriteLine($"{day2}.{month}.{year}");
            }
            
        }
    }
}
