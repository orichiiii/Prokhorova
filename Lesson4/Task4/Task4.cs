using System;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            //Необходимо добавить элемент в конец массива и вывести весь массив в консоль. 
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            var array = new int[] { 0, 1, 3, 67, 5, 2, 1, -4, -1, 99, 111};
            int index = array.Length;
            int value = 4;
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            for (int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];
            array = newArray;
            foreach (var symbol in array)
            {
                Console.WriteLine(symbol);
            }
            Console.ReadKey();
        }
    }
}
