using System;

namespace Lesson2_Task4
{
    class Lesson2_Task4
    {
        static void Main(string[] args)
        {
            /*Найти кол-во дубликатов "я" в предложении и вывести их кол-во - 
            "Вчера я был на речке, там я купался и загорал, из-за того, что я уснул, то я очень обгорел."*/
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            string strng = "Вчера я был на речке, там я купался и загорал, из-за того, что я уснул, то я очень обгорел.";
            strng = strng.Substring(7, 84);
            string[] strArray = strng.Split(' ');
            int count = 0;
            for (int i = 0; i < strArray.Length; i++)
                if (strArray[i].Equals("я")) 
                    count++;
            Console.WriteLine($"Количество дубликатов: {count}");
            Console.ReadKey();
        }
    }
}
