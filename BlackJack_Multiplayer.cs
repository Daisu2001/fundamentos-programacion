using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace te_destruyo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int cartas = 0, total = 0;
            string continuar = "s";
            int jugador = 0;
            int n = 5;


            while (jugador < n)
            {

                Console.WriteLine("bienvenido jugador " + jugador);

                cartas = aleatorio.Next(1, 10);
                Console.WriteLine("carta =" + cartas);
                total += cartas;
                Console.WriteLine("total =" + total);

                cartas = aleatorio.Next(1, 10);
                Console.WriteLine("carta =" + cartas);
                total += cartas;
                Console.WriteLine("total =" + total);

                Console.WriteLine("desea continuar?? (s/n)");
                continuar = Console.ReadLine();

                while (continuar == "s" && total < 21)
                {
                    cartas = aleatorio.Next(1, 10);

                    Console.WriteLine("carta =" + cartas);
                    total += cartas;
                    Console.WriteLine("total =" + total);

                    if (total == 21)
                    {
                        Console.WriteLine("felicitaciones, ganaste!!");
                        break;
                    }


                    if (total > 21)
                    {
                        Console.WriteLine("limite de 21 excedido, no puede continuar");

                    }
                    else
                    {
                        Console.WriteLine("desea continuar?? (s/n)");
                        continuar = Console.ReadLine();
                    }

                    Console.WriteLine("total =" + total);

                }

                total = 0;
                Console.WriteLine("gracias por participar");
                jugador += 1;
            }

            Console.ReadKey();

        }
    }
}
