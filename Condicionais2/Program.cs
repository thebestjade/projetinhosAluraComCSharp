using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int idadeJade = 15;
            //int qtdePessoas = 1;
            //bool acompanhado = qtdePessoas >= 2;

            //if (idadeJade >= 18 || acompanhado)
            //{
            //    Console.WriteLine("Pode entrar!");
            //}
            //else
            //{

            //    Console.WriteLine("Não pode entrar");

            //}

            //double salario = 4000.0;

            //if (salario >= 1900.0 && salario <= 2800.0)
            //{
            //    Console.WriteLine("Você pode deduzir na declaração o valor de R$ 142");
            //}
            //else if (salario >= 2800.01 && salario <= 3751.0)
            //{
            //    Console.WriteLine("Você pode deduzir R$ 350");
            //}
            //else if (salario <= 4664.00)
            //{
            //    Console.WriteLine("Você pode deduzir R$ 636");
            //}

            int mes = 7;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Mês de janeiro");
                    break;
                case 2:
                    Console.WriteLine("Mês de fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Mês de março");
                    break;
                case 4:
                    Console.WriteLine("Mês de abril");
                    break;
                case 5:
                    Console.WriteLine("Mês de maio");
                    break;
                case 6:
                    Console.WriteLine("Mês de junho");
                    break;
                case 7:
                    Console.WriteLine("Mês de julho");
                    break;
                case 8:
                    Console.WriteLine("Mês de agosto");
                    break;
                case 9:
                    Console.WriteLine("Mês de setembro");
                    break;
                case 10:
                    Console.WriteLine("Mês de outubro");
                    break;
                case 11:
                    Console.WriteLine("Mês de novembro");
                    break;
                case 12:
                    Console.WriteLine("Mês de dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
