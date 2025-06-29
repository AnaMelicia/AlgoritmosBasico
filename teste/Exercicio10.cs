using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class Exercicio_10
    {
        public static void Executar()
        {

            Console.WriteLine("Digite um número entre 1 e 100:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O " + numero + " é par!");
            }
            else
            { 
                Console.WriteLine("O " + numero + " é ímpar!"); 
            }
        }
    }
}
