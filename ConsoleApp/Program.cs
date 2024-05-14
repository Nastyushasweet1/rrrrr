using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Book<T1, T2>
    {
        public T1 Ptice { get; set; }
        public double Sum(T1 val1, T2 val2)
        {
            double dval1 = Convert.ToDouble(val1);
            double dval2 = Convert.ToDouble(val2);
            return dval1 + dval2;
        }

    }
    internal class Program
    {
        
        static void Main(string[] args, double)
        {
              Book<int, int> obj  = new Book<int, int>();
            double v = obj.Sum(100, 300);
            Console.ReadKey();
             
        }
    }
}
