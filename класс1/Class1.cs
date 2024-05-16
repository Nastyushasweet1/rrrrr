using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace класс1
{
    internal class Trapezoid<T> where T : struct
    {
        T a;
        T b;
        T h;
        public T A { get; set; }
        public T B { get; set; }
        public T H { get; set; }
        public Trapezoid(T a, T b, T h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }
        // Метод для вычисления площади трапеции
        public double Area()
        {
            double result = (Convert.ToDouble(a) + Convert.ToDouble(b)) / 2 * Convert.ToDouble(h);
            return result;
        }
        // Свойства для доступа к внутренним полям   
    }
}
