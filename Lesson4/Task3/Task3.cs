using System;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            var arrayOfInt = new int[] { 0, 7, 3, 4, 5, 6, -1, 8, 9 };
            int index = 0;
            while (arrayOfInt[index] != -1)
            {
                Console.WriteLine(arrayOfInt[index]);
                index++;
            }
        }
    }
}
