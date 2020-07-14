using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_2___3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese datos w:");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese datos t:");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese datos c:");
            double cGrados = double.Parse(Console.ReadLine());

            double c = cGrados * (Math.PI / 180.0);

            double z = (t / Math.Sin(c));
            double y = (z / Math.Tan(c));
            double e = (180 - c);
            double a = (180 - 90 - c);
            double d = (Math.Asin(w / z));
           
            double b = (180 - d - e);
            double x = ((z / Math.Tan(d)) - y);

            Console.WriteLine("x:" + x);

            Console.ReadKey();
        }
    }
}
