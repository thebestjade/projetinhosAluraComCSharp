using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescobrindoFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4! = 1*2*3*4 = 24
            int fatorial = 1;

            for(int i=1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("O resultado do fatorial de " + i + " é igual a " + fatorial);
            }
            

            Console.ReadLine();
        }
    }
}
