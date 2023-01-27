using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mes1, mes2;
            int mes3 = 0;

            Console.WriteLine("Qual foi o faturamento do primeiro mês?");
            mes1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi o faturamento do segundo mês?");
            mes2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi o faturamento do terceiro mês?");
            mes3 = int.Parse(Console.ReadLine());

            var total = (mes1 + mes2 + mes3) / 3;

            Console.WriteLine($"A média do faturamento trimestral foi de {total} reais.");
            Console.ReadLine();



        }
    }
}
