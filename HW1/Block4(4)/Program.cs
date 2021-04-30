using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            double x1;
            double x2;
            double y1;
            double y2;
            double z1;
            double z2;
            double dist;
            Console.WriteLine("Введите координаты точки А:");
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z1 = ");
            z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите координаты точки B:");
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("z2 = ");
            z2 = Convert.ToDouble(Console.ReadLine());


            dist = Form(x1, x2, y1, y2, z1, z2);
            Console.WriteLine("Расстояние между точками А и В = " + dist);
        }
        static double Form(double x1, double x2, double y1, double y2, double z1, double z2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        }
    }

}
