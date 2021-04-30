using System;

namespace Task1._1
{
    class Program
    {
        static void Main()
        {
            //Создать калькулятор с использованием методов.Учесть ввод невалидных данных. Учесть, что делить на 0 нельзя.
            //Операции которые можно сделать, +, -, *, /, %.
            //С результатом выполнения можно продолжать выполнять математические действия, если пользователь хочет.
            while (true)
            {
                double firstValue;
                double secondValue;
                while (true)
                {
                    Console.Write("Введите 1 число: ");
                    var firstVal = Console.ReadLine();
                    if (double.TryParse(firstVal, out firstValue))
                        break;
                    else
                        Console.WriteLine("Вы ввели некорректные данные.");
                }
                while (true)
                {
                    Console.Write("Введите 2 число: ");
                    var secondVal = Console.ReadLine();
                    if (double.TryParse(secondVal, out secondValue))
                        break;
                    else
                        Console.WriteLine("Вы ввели некорректные данные.");
                }
                Console.Write("Выберите операцию +, -, *, /, %:  ");
                var operation = Console.ReadLine();
                var result = QQQ(ref firstValue, secondValue, operation);
                Console.WriteLine($"Результат: {result}");
                while (true)
                {
                    Console.WriteLine("Хотите продолжить работу с результатом?");
                    if (!Console.ReadLine().ToLower().Equals("да"))
                        break;
                    Console.Write("Выберите операцию +, -, *, /, %:  ");
                    operation = Console.ReadLine();
                    while (true)
                    {
                        Console.Write("Введите 2 число: ");
                        var secondVal = Console.ReadLine();
                        if (double.TryParse(secondVal, out secondValue))
                            break;
                        else
                            Console.WriteLine("Вы ввели некорректные данные.");
                    }
                    Console.WriteLine($"Результат: {QQQ(ref result, secondValue, operation)}");

                }
            }
            

        }
        static double QQQ(ref double firstVal, double secondVal, string operation)
        {
            double res = 0; 
            switch (operation)
            {
                case "+":
                    res = firstVal + secondVal;
                    break;
                case "-":
                    res = firstVal - secondVal;
                    break;
                case "*":
                    res = firstVal * secondVal;
                    break;
                case "/":
                    if (secondVal == 0)
                        Console.WriteLine("На ноль делить нельзя.");
                    else
                    {
                        res = firstVal / secondVal;
                    }
                    break;
                case "%":
                    if (secondVal == 0)
                        Console.WriteLine("На ноль делить нельзя.");
                    else
                    {
                        res = firstVal % secondVal;
                    }
                    break;
                default:
                    break;
            }
            return res; 
        }
    }
}
