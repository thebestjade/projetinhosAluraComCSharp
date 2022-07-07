using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixandoForREAK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parando o laço de repetição com o BREAK
            for(int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna <= 10; contadorColuna++)
                {
                    //Console.Write("*");

                    if (contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                   
                    
                }

                Console.WriteLine();

            }

            //ou pode fazer dessa forma (sem o break):

            for (int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
