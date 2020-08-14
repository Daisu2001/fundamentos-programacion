using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciclos_p2___clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int dado = 0, total = 0;
            string continuar = "s", usarDadoEs = "";
            int countSeis = 0, CountDadoEs = 2;
            int vidas = 3;


            Console.WriteLine("bienvenido");

            dado = aleatorio.Next(1, 7);
            Console.WriteLine("sacó " + dado);
            total += dado;

            Console.WriteLine("su total es: " + total + " desea continuar? (s/n)");
            continuar = Console.ReadLine();
            while (continuar == "s")
            {

                Console.WriteLine("Desea usar un dado de doce caras? tiene: " + CountDadoEs + " disponible(s) (s/n)");
                usarDadoEs = Console.ReadLine();

                if(usarDadoEs == "s" && CountDadoEs != 0)
                {
                    dado = aleatorio.Next(1, 13);
                    Console.WriteLine("sacó " + dado);
                    total += dado;
                }
                else { 

                dado = aleatorio.Next(1, 7);
                Console.WriteLine("sacó " + dado);
                total += dado;
                }



                if (dado == 1)
                {
                    Console.WriteLine("pierde una vida y -10 a puntuación total");
                    vidas -= 1;
                    total -= 10;

                }

                Console.WriteLine("Usted tiene " + vidas + " vidas");

                if (dado == 6)
                {
                    countSeis = 1;
                }
                else 
                {
                    countSeis = 0;
                }

                if (dado == 6 && countSeis == 2 && vidas < 3)
                {
                    Console.WriteLine("Vida extra");
                    vidas += 1;
                    countSeis = 0;
                    
                }

                if(vidas == 0)
                {
                    Console.WriteLine("se ha quedado sin vidas");
                    break;
                }



                if (total >= 100)
                {
                    Console.WriteLine("ganaste");
                    break;
                }

               
              
                Console.WriteLine("su total es: " + total + " desea continuar? (s/n)");
                continuar = Console.ReadLine();

               

            }
            Console.ReadKey();

        }
    }
}
