using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] valores = { "-", "-", "o", "x" };

            int m = 15, n = 10;
            int countO = 0;
            int countX= 0;
            int countRaya = 0;
            double PromedioX = 0;
            double PromedioO = 0;
            double PromedioRaya = 0;



            string[,] tablero = new string[n, m];
            string[,] salida = new string[n, m];

            for(int i = 0; i < tablero.GetLength(0) ; i++)
            {
                for(int j  = 0; j < tablero.GetLength(1) ; j++)
                {
                    int indice = random.Next(0, valores.Length);
                    tablero[i, j] = valores[indice];
                    salida[i, j] = "-";
                }
            }


            Console.WriteLine("Entrada: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    if(tablero[i,j] == "x")
                    {
                        countX += 1;
                    }
                    if (tablero[i, j] == "o")
                    {
                        countO += 1;
                    }
                    if (tablero[i, j] == "-")
                    {
                        countRaya += 1;
                    }

                    Console.Write("|" + tablero[i, j]);
                }
                Console.Write("|\n");
            }
            


            for (int i = 0; i < tablero.GetLength(0) - 2; i++)
            {

                for (int j = 0; j < tablero.GetLength(1) - 2; j++)
                {


                    if (tablero[i, j] == tablero[i + 2, j] && tablero[i, j] == tablero[i + 1, j] && tablero[i, j] == "x")
                    {
                        salida[i, j] = "1";
                        salida[i + 2, j] = "1";
                        salida[i + 1, j] = "1";
                    }
                    if (tablero[i, j] == tablero[i, j+2] && tablero[i, j] == tablero[i, j + 1] && tablero[i, j] == "x")
                    {
                        salida[i, j] = "1";
                        salida[i , j + 2] = "1";
                        salida[i , j + 1] = "1";
                    }
                    if (tablero[i, j] == tablero[i + 2, j] && tablero[i, j] == tablero[i + 1, j] && tablero[i, j] == "o")
                    {
                        salida[i, j] = "2";
                        salida[i + 2, j] = "2";
                        salida[i + 1, j] = "2";
                    }
                    if (tablero[i, j] == tablero[i, j + 2] && tablero[i, j] == tablero[i, j + 1] && tablero[i, j] == "o")
                    {
                        salida[i, j] = "2";
                        salida[i, j + 2] = "2";
                        salida[i, j + 1] = "2";
                    }






                }
            }


            Console.WriteLine("\nSalida: ");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                
                for (int j = 0; j < tablero.GetLength(1); j++)
                {


                    Console.Write("|" + salida[i, j]);
                    
                }
                Console.Write("|\n");
            }
            Console.Write("\n");


            PromedioX = (countX * 100) / tablero.Length;
            Console.WriteLine("el promedio de X es: " + PromedioX + "%");
            PromedioO = (countO * 100) / tablero.Length;
            Console.WriteLine("el promedio de O es: " + PromedioO + "%");
            PromedioRaya = (countRaya * 100) / tablero.Length;
            Console.WriteLine("el promedio de - es: " + PromedioRaya + "%");




        }
    }
}
