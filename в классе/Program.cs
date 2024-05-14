using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace в_классе
{
    class Terem<T1, T2>
    {
        public T1 FIO { get; set; }
        public T2 Group { get; set; }

        public void Info(T1 FIO, T2 Group)
        {
            
            Console.WriteLine($" {FIO}  учится в группе {Group}");

        }
        //    public T1 Ptice` { get; set; }
        //    public double Sum(T1 val1, T2 val2)
        //    {
        //        double dval1 = Convert.ToDouble(val1);
        //        double dval2 = Convert.ToDouble(val2);
        //        return dval1 + dval2;
        //    }

        //}
        //internal class Program
        //{

        static void Main(string[] args, double)
        {
            //Terem<int, int> obj = new в_классе.Terem<int, int>();
            //double v = obj.Sum(100, 300);
            Terem<string, string> student = new Terem<string, string>
            {

            };
            student.FIO = "Пупок Муровья";
            gro
            Console.ReadKey();
            
        }
    }
}
