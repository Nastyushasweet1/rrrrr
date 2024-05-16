using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rkfcc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта с типами int и string
            GenericClass<int, string> obj1 = new GenericClass<int, string>(42, "Hello");
            obj1.PrintFields(); // Выведет: val1: 42, val2: Hello

            // Изменение значений внутренних полей через свойства
            obj1.Val1 = 100;
            obj1.Val2 = "World";
            obj1.PrintFields(); // Выведет: val1: 100, val2: World

            // Создание объекта с типами double и bool
            GenericClass<double, bool> obj2 = new GenericClass<double, bool>(3.14, true);
            obj2.PrintFields(); // Выведет: val1: 3.14, val2: True
        }
    }
}
