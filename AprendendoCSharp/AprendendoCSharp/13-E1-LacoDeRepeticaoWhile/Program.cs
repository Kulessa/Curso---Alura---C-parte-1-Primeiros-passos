﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_E1_LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.ReadLine();
        }
    }
}
