using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_rkfcct2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account <int> acc1 = new Account <int>();
            acc1.Sum = 5000;
            acc1.Id = 2; //упаковка 

            Account  <string> acc2 = new Account <string> ();
            acc2.Sum = 4000;
            acc2.Id = 3;

            Console.WriteLine($"id счета:{(int)acc1.Id}, сумма на счету: {acc1.Sum}");
            Console.WriteLine($"id счета:{(string)acc2.Id}, сумма на счету: {acc2.Sum}");
            Console.ReadKey();

        }
    }
}
