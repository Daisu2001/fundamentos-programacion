using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclos_1___2
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("ingrese el numero de datos: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, min = 200, max = 0;
            string nombremin = "";
            string nombremax = "";

            while (i < n)
            {
                Console.Write("edad:");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("nombre: ");
                string nombre = (Console.ReadLine());

                
                if (edad > max)
                {
                    max = edad;
                    nombremax = nombre;

                }


                if (edad < min)
                {
                    min = edad;
                    nombremin = nombre;
                }


                total += edad;
                i++;
            }

            double promedio = total / n;
            Console.WriteLine("el promedio es:" + promedio);
            Console.WriteLine("el mayor es: " + nombremax+ "  tiene: " + max);
            Console.WriteLine("el menor es: " + nombremin + "  tiene: " + min);
            Console.ReadKey();

            
           

        }
    }
}
