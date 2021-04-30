using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Task3
{
    public class PersonsLog : Library
    {
        public static readonly Dictionary<string, int> _personsLog = new Dictionary<string, int>();

        public static void PersonData(Book userBook)
        {
            if (BooksCatalog.Contains(userBook))
            {
                int daysOfUse;
                while (true)
                {
                    Write("Please enter the number of days for which you want to take this book: ");
                    var days = ReadLine();

                    if (int.TryParse(days, out daysOfUse))
                        break;
                    else                   
                      WriteLine("You entered incorrect data.");                   
                }

                Write("Please enter your name: ");
                var personName = ReadLine();

                AddToLog(personName, daysOfUse);

                userBook.DaysofUse = daysOfUse;
            }
            else
                Write("This book does not exists in our library.");
        }

        public static void AddToLog(string personName, int days)
        {
            if (!_personsLog.ContainsKey(personName))
            {
                _personsLog[personName] = days;
                WriteLine("Your data has been successfully written to the log.");
            }
            else
                WriteLine("This name already exists in our log, please enter another name or add numbers.");
        }
    }
}
