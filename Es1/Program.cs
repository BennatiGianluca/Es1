﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> doppioni = new List<int>();
            Console.WriteLine("Quanti numeri vuoi inserire?");
            int n = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>(n);
            for (int i = 0; i< n; i++)
            {
                Console.WriteLine("Inserisci un numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (lista.Contains(numero))
                    doppioni.Add(numero);
                lista.Add(numero);
            }
            for (int i = 0; i < doppioni.Count; i++)
            {
                Console.WriteLine($"Il numero {doppioni[i]} è doppione.");
            }
            Console.ReadLine();
        }
    }
}
