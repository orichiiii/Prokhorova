using System;

namespace Lesson2_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку №1: ");
            string strng = Console.ReadLine();
            Console.Write("Введите строку №2: ");
            string strng2 = Console.ReadLine();
            Console.Write("Введите строку №3: ");
            string strng3 = Console.ReadLine();
            Console.Write("Введите строку №4: ");
            string strng4 = Console.ReadLine();
            string[] strngArray = strng.Split(' ');
            string[] strng2Array = strng2.Split(' ');
            string[] strng3Array = strng3.Split(' ');
            string[] strng4Array = strng4.Split(' ');
            string val = string.Empty;
            for (int i = 0; i < strngArray.Length - 1; i++)
            {
                char[] s = strngArray[i].ToCharArray();
                int j = 0;
                int k = s.Length - 1;
                while (j < k)
                {
                    char a = s[j];
                    char b = s[k];
                    if (char.ToLower(a) == char.ToLower(b))
                    {
                        val = strng;
                        break;
                    }
                    j++;
                    k--;
                }
            }
            for (int i = 0; i < strng2Array.Length - 1; i++)
            {
                char[] s = strng2Array[i].ToCharArray();
                int j = 0;
                int k = s.Length - 1;
                while (j < k)
                {
                    char a = s[j];
                    char b = s[k];
                    if (char.ToLower(a) == char.ToLower(b))
                    {
                        Console.WriteLine(strng2);
                        break;
                    }
                    j++;
                    k--;
                }
            }
            for (int i = 0; i < strng3Array.Length - 1; i++)
            {
                char[] s = strng3Array[i].ToCharArray();
                int j = 0;
                int k = s.Length - 1;
                while (j < k)
                {
                    char a = s[j];
                    char b = s[k];
                    if (char.ToLower(a) == char.ToLower(b))
                    {
                        Console.WriteLine(strng3);
                        break;
                    }
                    j++;
                    k--;
                }
            }
            for (int i = 0; i < strng4Array.Length - 1; i++)
            {
                char[] s = strng4Array[i].ToCharArray();
                int j = 0;
                int k = s.Length - 1;
                while (j < k)
                {
                    char a = s[j];
                    char b = s[k];
                    if (char.ToLower(a) == char.ToLower(b))
                    {
                        Console.WriteLine(strng4);
                        break;
                    }
                    j++;
                    k--;
                }
            }
        }
    }
}
