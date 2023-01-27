using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa04.Aplicação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int premio = 0 ;
            int r = (5000 / 10);

            Console.WriteLine("Parabéns vocé ganhou um premio! ");
            Console.WriteLine("Quanto você acha que ganhou?");
            premio = int.Parse(Console.ReadLine());

            if (premio < 500)
            {

                Console.WriteLine("Você ganhou mais! \n Seu premio foi de " + r + " reais. ");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Você ganhou apenas " + r + " reais, espero que ajude!");
                Console.ReadLine();


            }



        }
    }
}
