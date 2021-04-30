using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;

namespace Task2
{
    public class CSVFormat : ITxtFormat
    {
        public static void GetText()
        {
            WriteLine("Plese enter text:");
            var textFromUser = ReadLine();

            StringFormat(textFromUser);
        }

        public static void StringFormat(string userText)
        {
            try
            {
                StreamWriter text = new StreamWriter("D:\\Test.txt");
                text.Write(userText);
                text.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
