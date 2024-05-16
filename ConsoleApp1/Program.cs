using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     internal class Hero
    {
        ~ Hero() { }
        public string Magical { get; set; }
        public string Talents { get; set; }
        public string Special_items { get; set; }
        string magical;
        string talents;
        string special_items;
        public Hero()
        {
            magical = null;
            talents = null;
            special_items = null;
            GetInfo();
            
        }
        public Hero (string magical, string talents, string special_items)
        {
            this.magical = magical; 
            this.talents = talents;
            this.special_items = special_items;
            GetInfo ();
        }
         void GetInfo()
        {
            Console.WriteLine($"magical {magical}");
            Console.WriteLine($"talents {talents}");
            Console.WriteLine($"special_items {special_items}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero pupokhnuka = new Hero();
            Hero pupokhnuka1 = new Hero ("pollen", "sing", "dragon");
            Console.ReadKey();
        }
    }
}
