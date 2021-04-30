using System;

namespace Task10
{
    class Task10
    {
        static void Main(string[] args)
        {
            /*Пользователь вводит 6 своих последних зарплат, ему выводится максимальная, минимальная, 
            средняя зп и общая сумма.Использовать массивы и циклы. Запрещено использовать LINQ.*/
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int[] salary = new int[6];
            int salaryNmber = 1;
            for (int i = 0; i < salary.Length; i++)
            {
                Console.Write($"Введите Вашу {salaryNmber} зарплату: ");
                salary[i] = int.Parse(Console.ReadLine());
                salaryNmber++;
            }
            float max = salary[0];
            float min = salary[0];
            float sum = salary[0];
            for (int i = 1; i < salary.Length; i++)
            {
                if (salary[i] > max)
                {
                    max = salary[i];
                }
                if (salary[i] < min)
                {
                    min = salary[i];
                }
                if (i < salary.Length)
                {
                    sum += salary[i];
                }
            }
            Console.WriteLine($"Ваша максимальная зарплата: {max}");
            Console.WriteLine($"Ваша минимальная зарплата: {min}");
            Console.WriteLine($"Сумма всех ваших зарплат: {sum}");
            Console.WriteLine($"Средняя зарплата: {sum / 6}");
        }
    }
}
