using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4_1_
{
    class Program
    {
        public enum Days
        {
            Понедельник = 1,
            Вторник = 2,
            Среда = 3,
            Четверг = 4,
            Пятница = 5,
            Суббота = 6,
            Воскресенье = 7
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введите число.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((Days)(n % Enum.GetValues(typeof(Days)).Length));
        }
    }
}
