using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese cuanto es su salario");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 1755606)
            {
                Console.WriteLine("Usted aplica para la tarifa A");
            } else if (salario >= 1755606 && salario < 3511212)
            {
                Console.WriteLine("usted aplica para la tarifa B");
            }else if(salario >= 3511212)
            {
                Console.WriteLine("usted aplica para la tarifa C");
            }

            Console.ReadKey();
        }
    }
}
