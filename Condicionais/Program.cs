using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeJade = 15;
            int qtdePessoas = 2;

            if (idadeJade >= 18)
            {
                Console.WriteLine("Idade maior ou igual a 18, pode entrar!");
            }
            else
            {
                if (qtdePessoas >= 2)
                {
                    Console.WriteLine("É de menor, porém está acompanhado, pode entrar!");
                }
                else
                {
                    Console.WriteLine("Não pode entrar, está desacompanhado e é de menor");
                }
            }


            Console.ReadLine();
        }
    }
}
