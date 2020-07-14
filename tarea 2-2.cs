using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese datos d:");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese datos b:");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese datos y:");
            double y = double.Parse(Console.ReadLine());

            double d = dGrados * (Math.PI / 180.0);
            double b = bGrados * (Math.PI / 180.0);

            double e = (180 - d - b);
            double c = (180 - e);
            double z = (y * Math.Tan(c));

            Console.WriteLine("z:" + z);

            Console.ReadKey();
        }
    }
}
