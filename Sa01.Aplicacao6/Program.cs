using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aviao1;
            double aviao2;
            double aviao3;
            double aviao4;

            int quantAviao1;
            int quantAviao2;
            int quantAviao3;
            int quantAviao4;


            double valorUnit;

            double subtotal1;
            double subtotal2;
            double subtotal3;
            double subtotal4;

            double totalGeral;

            Console.WriteLine("Qual o valor do primeiro avião?");
            aviao1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos desse tipo você deseja?");
            quantAviao1 = int.Parse(Console.ReadLine());
            subtotal1 = aviao1 * quantAviao1;

            Console.WriteLine("Qual o valor do primeiro avião?");
            aviao2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos desse tipo você deseja?");
            quantAviao2 = int.Parse(Console.ReadLine());
            subtotal2 = aviao2 * quantAviao2;

            Console.WriteLine("Qual o valor do primeiro avião?");
            aviao3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos desse tipo você deseja?");
            quantAviao3 = int.Parse(Console.ReadLine());
            subtotal3= aviao3 * quantAviao3;

            Console.WriteLine("Qual o valor do primeiro avião?");
            aviao4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos desse tipo você deseja?");
            quantAviao4 = int.Parse(Console.ReadLine());
            subtotal4= aviao4 * quantAviao4;

            totalGeral = subtotal1 + subtotal2 + subtotal3 + subtotal4;
            var quantAviaoTotal = quantAviao1 + quantAviao2 + quantAviao3 + quantAviao4;


            Console.WriteLine($"O seus {quantAviaoTotal} aviões deram um tota de {totalGeral} reais. ");
            Console.ReadLine();


        }
    }
}
