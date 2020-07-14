using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese datos w:");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese datos d:");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese datos x:");
            double x = double.Parse(Console.ReadLine());

            double d = dGrados * (Math.PI / 180.0);

            double z = (Math.Sin(d) * w);
            double y = ((z / Math.Tan(d)) - x);

            Console.WriteLine("y:" + y);
            Console.ReadKey();
        }
    }
}
