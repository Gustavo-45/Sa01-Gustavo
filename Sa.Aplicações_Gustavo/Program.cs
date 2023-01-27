using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
          Console.WriteLine("Qual o valor do primeiro avião?");
             x = int.Parse(Console.ReadLine());
          Console.WriteLine("Qual o valor do segundo avião?");
             y = int.Parse(Console.ReadLine());

            var r = y + x;
            
            Console.WriteLine($"O seus aviões valem " + r  + " reais.");
            Console.ReadLine();
        

        }
    }
}
