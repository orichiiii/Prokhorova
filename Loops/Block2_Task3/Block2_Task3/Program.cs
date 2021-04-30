using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введите число.");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine("Число должно быть больше 0.");
            double a = Math.Sqrt((n));
            a = Convert.ToInt32(a);
            Console.WriteLine("корень из числа = " + a);
        }
    }
}
