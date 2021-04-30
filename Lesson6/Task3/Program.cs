using System;
using System.Collections.Generic;
using static System.Console;

namespace Task3
{
    internal class Program
    {

        private static readonly Dictionary<string, string> _phoneBook = new Dictionary<string, string>();

        private static void Main()
        {
            /*
             * 3.Создать телефонную книгу, в которую пользователь может добавлять контакты, удалять контакты, 
             * обновлять контакты, и выводить все контакты в виде имен и их номеров телефонов, 
             * либо выводить какой - то один номер для определенно контакта.
             * Необходимо использовать Dictionary при решении данной задачи.
             * Учесть все негативные сценарии в связи с работой с Dictionary. 
             * Программа должна работать циклично.
             */

            while (true)
                ChooseAction();
        }

        private static void ChooseAction()
        {
            WriteLine("\n Please choose the action: \n (A) Add, (D) Delete, (Сh) Change phone number, (Sh) Show all contacts, (O) Show one contact.");
            var userOperation = ReadLine();

            switch (userOperation.ToLower())
            {
                case "a": AddInfo(); break;
                case "d": DeleteInfo(); break;
                case "ch": ChangePhoneNumber(); break;
                case "sh": ShowInfo(); break;
                case "o": ShowOneContact(); break;
                default: throw new ArgumentException($"Invalid operation {userOperation}.");
            }
        }

        private static void ShowOneContact()
        {
            Write("Enter tne name ");
            var name = ReadLine();

            if (_phoneBook.ContainsKey(name.ToLower()))            
               WriteLine(_phoneBook[name.ToLower()]);  
            
            else            
               WriteLine("This name does not exist in the phone book.");            
        }

        private static void ShowInfo()
        {
            foreach (var dataFromPhoneBook in _phoneBook)
            {
                WriteLine(dataFromPhoneBook);
            }
            if (_phoneBook.Count == 0)
                WriteLine("The phone book is empty.");
        }

        private static void ChangePhoneNumber()
        {
            WriteLine("Enter the name you want to change the number for.");
            var name = ReadLine();

            if (_phoneBook.ContainsKey(name.ToLower()))
            {
                WriteLine("Enter new number.");
                var newNumber = ReadLine();

                _phoneBook[name] = newNumber;
            }
            else
                WriteLine("This name is not in the phone book.");
        }

        private static void AddInfo()
        {
            Write("Enter the name: ");
            var name = ReadLine();

            Write("Enter the phone number: ");
            var phoneNumber = ReadLine();

            _phoneBook.Add(name.ToLower(), phoneNumber);
        }

        private static void DeleteInfo()
        {
            if (_phoneBook.Count == 0)            
              WriteLine("The phone book is empty.");            
            else
            {
                Write("Enter tne name ");
                var name = ReadLine();

                if (_phoneBook.ContainsKey(name.ToLower()))              
                  _phoneBook.Remove(name.ToLower());     
                
                else               
                   WriteLine("This name does not exist in the phone book.");                
            }
        }
    }
}
