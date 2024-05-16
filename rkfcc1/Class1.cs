using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rkfcc1
{
    public class GenericClass<T1, T2>
    {
        // внутренние поля
        private T1 val1;
        private T2 val2;

        // конструктор с двумя параметрами
        public GenericClass(T1 val1, T2 val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }

        // метод, выводящий информацию о внутренних полях
        public void PrintFields()
        {
            Console.WriteLine($"val1: {val1}, val2: {val2}");
        }

        // свойства для доступа к внутренним полям
        public T1 Val1
        {
            get { return val1; }
            set { val1 = value; }
        }

        public T2 Val2
        {
            get { return val2; }
            set { val2 = value; }
        }
    }
}
