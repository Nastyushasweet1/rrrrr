using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace вклассе4
{
    internal class Point
    {
        static void Main(string[] args)
        {
            Point<int> point  = new Point <int> (23,15);
            Point<double> point1 = new Point<double>(7.88 ,-3.22);
            Console.ReadKey();
        }
    }
}
