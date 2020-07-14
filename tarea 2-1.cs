using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segunda_asesoría
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese datos b: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese datos z: ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese datos y: ");
            double y = double.Parse(Console.ReadLine());

            double b = bGrados * (Math.PI / 180.0);

            double tcuadrado = ((y * y) + (z * z));
            double t = Math.Sqrt(tcuadrado);

            double c = Math.Asin(z / t);
            double e = (180 - c);
            double d = (180 - b - e);
            double x = (z / (Math.Tan(d)) - y);

            Console.WriteLine("x:" + x);

            Console.ReadKey();





        }
    }
}
