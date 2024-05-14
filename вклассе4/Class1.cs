using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace вклассе4
{
    internal class Point <T>
    {
        public T X { set; get; }
        public T Y { set; get; }
        public Point(T x, T y)
        {
            X = x;
            Y = y;
            GetInfo();
        }
        void GetInfo()
        {
            Console.WriteLine($"x = {X}, y = {Y}");
        }

    }
          
}
