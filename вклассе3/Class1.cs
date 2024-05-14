using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вклассе3
{
    internal class MyGenericClass<T>
    {
        T a; // обобщение поля
        public MyGenericClass
      {
            a = default (T);
            Get_Info();
      }
      void Get_Info()
      {
        Console.Write($"\n Значенеие типа по умолчанию : {a}.");
      }
} 

