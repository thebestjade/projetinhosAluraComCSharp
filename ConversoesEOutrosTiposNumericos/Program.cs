using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 1250.50;
            int valor = (int)salario;

            Console.WriteLine(valor);

            float pontoFlutuante = 3.14f;



            double valor1 = 0.2;
            double valor2 = 0.3;
            double total = valor1 + valor2;
            Console.WriteLine(total);       

            Console.ReadLine();

        }
    }
}
