using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peca1;
            double peca2;
            double peca3;
            double peca4;
            double peca5;
            

            Console.WriteLine("Vamos fazer um levantamento de quanto temos em peças na oficina. \n Qua o valor da primeira peça?");
            peca1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qua o valor da seguanda peça?");
            peca2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qua o valor da terceira peça?");
            peca3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qua o valor da quarta peça?");
            peca4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qua o valor da quinta peça?");
            peca5 = double.Parse(Console.ReadLine());

            var pecaTotal = peca1 + peca2 + peca3 + peca4+ peca5;

            Console.WriteLine($"O valor das peças é de {pecaTotal} reais.");
            Console.ReadLine();

           

        }
    }
}
