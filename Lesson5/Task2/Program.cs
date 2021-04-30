using System;

namespace Task2
{
    class Program
    {
        static void Insert(ref string[] array, string value, int index)
        {
            var newArray = new string[array.Length + 1];
            newArray[index] = value;
            for (var i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (var i = index; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            array = newArray;
        }

        static void RemoveName(ref string[] array, int index)
        {
            var newArray = new string[array.Length - 1];
            for (var i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (var i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            array = newArray;
        }

        static void Main()
        {
            //Создать некую книгу имен.
            //Имена могуть быть как на латыни так и на кириллице.
            //Пользователь может добавить имя, удалить его, вывести весь список имен. 
            //Т.е.программа должна запрашивать какое действие хочет сделать пользователь, и после уже идет его выполнение.
            //Учесть ввод невалидных данных. Выполнить с использованием методов, массивов и циклов.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            var nameArray = new string[0];
            
            do
            {
                Console.Write("Выберите операцию: добавить, удалить, вывести список: ");
                var newOperation = Console.ReadLine();
                var operation = newOperation.ToLower();
                
                var name = string.Empty;
                
                if (operation == "добавить" || operation == "удалить")
                {
                    Console.Write("Введите имя: ");
                    name = Console.ReadLine();
                }
                
                switch (operation)
                {
                    case "добавить":
                        Insert(ref nameArray, name, nameArray.Length);
                        break;
                    case "удалить":
                        if (operation == "удалить" && nameArray.Length == 0)
                            Console.WriteLine("Книга имён пустая.");
                        else
                            RemoveName(ref nameArray, name.IndexOf(name));
                        break;
                    case "вывести список":
                        foreach (var names in nameArray)
                        {
                            Console.WriteLine(names);
                        }
                        break;
                    default:
                        Console.WriteLine("Вы ввели неккоректные данные.");
                        break;
                }
               
                Console.Write("Нажмите ESC, чтобы выйти.");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}

