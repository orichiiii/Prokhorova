using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double diameter;
            while (true)
            {
                Console.WriteLine("Введите диаметр окружности.");
                diameter = double.Parse(Console.ReadLine());
                if (diameter < 0)
                    Console.WriteLine("Введите диаметр больше 0.");
                else
                    break;
            }

            var radius = diameter / 2;
            Console.WriteLine("Что вы хотите найти? Введите Периметр, Площадь или Радиус: ");
            var formula = Console.ReadLine();
            double perimeter;
            double area;
            switch (formula.ToLower())
            {
                case "периметр":
                    Perimeter(radius, out perimeter);
                    Console.WriteLine($"Периметр окружности равен {perimeter}");
                    break;
                case "площадь":
                    Area(radius, out area);
                    Console.WriteLine($"Периметр окружности равен {area}");
                    break;
                case "радиус":
                    Console.WriteLine($"Радиус окружности равен {radius}");
                    break;
                default:
                    Console.WriteLine("Вы ввели неккоректные данные.");
                    break;
            }
        }
        static void Perimeter(double radius, out double perimeter)
        {
            perimeter = 2 * 3.14 * radius;
        }
        static void Area(double radius, out double area)
        {
            area = 3.14 * Math.Pow(radius, 2);
        }
    }
    }
}
