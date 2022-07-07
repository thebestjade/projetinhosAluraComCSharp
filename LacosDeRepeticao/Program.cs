using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dinheiroInvestido = 2500;
            float taxa = 0.0036f;
            int totalMeses = 6;
            int contador = 1;

            for (int i = 1; i <= totalMeses; i++)
            {
                //dinheiroInvestido = dinheiroInvestido + (dinheiroInvestido * taxa);
                dinheiroInvestido *= 1 + taxa;
            }

            //while(contador <= totalMeses)
            //{
                //dinheiroInvestido = dinheiroInvestido + (dinheiroInvestido * taxa);
                //contador++;
            //}

            Console.WriteLine("Após " + totalMeses + " você terá " + dinheiroInvestido + " reais investido");

            Console.ReadLine();
        }
    }
}
