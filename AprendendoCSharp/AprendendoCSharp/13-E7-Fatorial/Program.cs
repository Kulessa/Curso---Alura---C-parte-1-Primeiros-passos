using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_E7_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= 1;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
            Console.ReadLine();
        }
    }
}
