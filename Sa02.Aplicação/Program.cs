using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicação1 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string resposta;
            int ano = (2023 - 1968);
            Console.WriteLine("Você quer saber qual o ano da criação do primeiro avião da Embraer?");
            resposta = Console.ReadLine();
            if (resposta == "Sim")
            {
                Console.WriteLine($"O primeiro avião da Embraer foi criado em 22 de Outubro 1962 ha " + ano + " anos atrás.");
            }
            else
            {
                Console.WriteLine("Muito bem!");
            }
           
        }

    }
}
