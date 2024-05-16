using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace класс1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение h: ");
double h = Convert.ToDouble(Console.ReadLine());
            Trapezoid<double> doubleTrapezoid = new Trapezoid<double>(a, b, h);
            double result = doubleTrapezoid.Area();
            Console.WriteLine($"Площадь трапеции: {result}");
            Console.ReadKey();
        }
    }
}
