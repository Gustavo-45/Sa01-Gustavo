using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa03.Aplicação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Console.WriteLine("Qual a quantidade de aviões?");
            x = int.Parse(Console.ReadLine());
            int r = (x * 17);
            Console.WriteLine($"Você tem " + r + " assenstos.");
            Console.ReadLine();

        }
    }
}
