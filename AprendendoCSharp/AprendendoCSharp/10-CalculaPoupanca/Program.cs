﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");
            double valorInvestido = 1000;
            //0.36% = 0.0036
            int contadorMes = 1;
            while (contadorMes <= 12)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " mês(es), você terá R$" + valorInvestido);
                contadorMes++;
            }
            Console.ReadLine();
        }
    }
}
