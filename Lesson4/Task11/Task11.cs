using System;

namespace Task11
{
    class Task11
    {
        static void Main(string[] args)
        {
            /*Пользователь может ввести сколько угодно данных в таблицу, формат ввода данных 23; Dima; Petrov; Dnepr;.
            Если он напишет stop, то программа выведет ему все данные,в таблице вида:
            | Age | First Name | Second Name | City |
            | 23 | Dima | Petrov | Dnepr |
            Любое из значений может отсутствовать -23; ; Petrov; Dnepr;*/
           
           
            int i = 0;
            string[,] personData = new string [i,3];
            personData[0, 0] = "Age";
            personData[0, 1] = "First Name";
            personData[0, 2] = "Second Name";
            personData[0, 3] = "City";
            Console.WriteLine("Введите данные в формате: 23; Dima; Petrov; Dnepr;");
        }
    }
}
