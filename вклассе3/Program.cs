using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вклассе3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<double> obj = new MyGenericClass<double>();
            MyGenericClass<bool> obj = new MyGenericClass<bool>();
            MyGenericClass<> obj = new MyGenericClass<bool>();

        }
    }
}
