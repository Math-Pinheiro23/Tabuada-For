using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Dejalma_08._06._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 0 ao 100.");

            int tab, num1, num2, resultado;

            Console.WriteLine("Digite o numero que você quer a tabuada: ");
            tab = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de 1 a 100 que deseja iniciar a tabuada.");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de 1 a 100 que deseja terminar a tabuada.");
            num2 = int.Parse(Console.ReadLine());


            for (; num1 <= num2; num1++)
            {         
                resultado = num1 * tab;
                Console.WriteLine(tab + "X" + num1 + " = " + resultado);
            }

            Console.ReadKey();
        }
    }
}
