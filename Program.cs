using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 atual, nasc, sub, rd;
            Console.WriteLine("Digite o ano atual.");
            atual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o seu ano de nascimento.");
            nasc = Convert.ToInt32(Console.ReadLine());
            sub = (atual - nasc);
            rd = (2050 -nasc);
            Console.WriteLine("Você tem "+ sub+ " anos.");
            Console.WriteLine("Você terá " + rd + " anos em 2050");
            Console.ReadKey();
        }
    }
}
