using System;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            /*Создать программу, которая может считать периметр, площу, радиус окружности в зависимости от того(известен диаметр), 
            что выберет пользователь.С использованием методов, и выходного параметра out. Учесть ввод негативных данных.*/
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            

        }

        public void MathOperation()
        {
            Console.WriteLine("Что вы хотите найти? Введите Периметр, Площадь или Радиус: ");
            var formula = Console.ReadLine();

            switch (formula.ToLower())
            {
                case "периметр":
                    Console.WriteLine($"Периметр окружности равен {Perimeter(InputDiameter())}");
                    break;
                case "площадь":
                    Console.WriteLine($"Площадь окружности равна {Area(InputDiameter())}");
                    break;
                case "радиус":
                    Console.WriteLine($"Радиус окружности равен {InputDiameter()}");
                    break;
                default:
                    Console.WriteLine("Вы ввели неккоректные данные.");
                    break;
            }
        }

        public double InputDiameter()
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

            return radius;
        }

        public double Perimeter(double radius)
        {
            var perimeter = 2 * 3.14 * radius;
            return perimeter;
        }

        public double Area(double radius)
        {
            var area = 3.14 * Math.Pow(radius, 2);
            return area;
        }
    }
}
