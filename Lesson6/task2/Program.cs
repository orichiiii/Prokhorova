using System;
using System.Collections.Generic;
using static System.Console;

namespace task2
{
    internal class Program
    {
        private static void Main()
        {
            /*
             * 2.Организовать очередь на прием к доктору с помощью Queue, чтобы пациент проводил у доктора от 5 до 15 секунд рандомно.
             * Кол - во пациентов должно быть не менее 5 - ти.Все действия должны выводиться в консоль.
             */

            var persons = new Queue<string>();

            persons.Enqueue("Tom");
            persons.Enqueue("Adam");
            persons.Enqueue("Diana");
            persons.Enqueue("Bob");
            persons.Enqueue("Mark");

            while (persons.Count != 0)
            {
                var time = new Random();
                var seconds = time.Next(5000, 15000);

                var patient = persons.Dequeue();
                WriteLine($"{patient} entered the doctor's office.");
                WriteLine($"{patient} is now at the doctor's.");

                System.Threading.Thread.Sleep(seconds);

                WriteLine($"{patient} left the doctor's office. \n");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
