using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiploDeTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multiplos de três
            for(int i=3; i < 100; i += 3)
            {
                //Console.WriteLine(i);   
            }

            for(int i=0; i<100; i++)
            {
                if( i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
