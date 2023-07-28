using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public  class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("***Smartphone Brand***\n");
            Smartphone smartphone = new Smartphone("Apple -","iPhone 12");
            smartphone.Connect();
            smartphone.Charge(60);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine("***Laptop Brand***\n");
            Laptop laptop = new Laptop("Dell -", "XPS 13");
            laptop.Connect();
            laptop.Charge(120);
            Console.WriteLine(laptop.Display());
            Console.ReadKey();
        }
    }
}

