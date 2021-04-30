using System;
using System.IO;
using static System.Console;


namespace Task2
{
    public class Program
    {
        //Создать программу, которая сохраняет введеный текст из консоли в файлы формата: txt,csv,pdf.
        //(Использовать интерфейсы и классы)
        //Пользователь должен иметь возможность выбора формата сохранения.Не валидные кейсы должны быть учтены.

        static public void Main()
        {
            SelectFileFormat();
        }

        public static void SelectFileFormat()
        {
            Write("Please select the file format: (1)txt, (2)pdf, (3)csv: ");
            var fileFormat = ReadLine();

            switch (fileFormat)
            {
                case "1": TXTFormat.GetText(); break;
                case "2": PDFFormat.GetText(); break;
                case "3": CSVFormat.GetText(); break;
                default: throw new ArgumentException($"Invalid operation {fileFormat}.");
            }
        }
    }
}
