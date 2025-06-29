using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class Exercicio_12
    {
        //Peça uma palavra e diga se ela é igual de trás pra frente.Ex: “ANA” é palíndromo.
        public static void Executar()
        {
            Console.WriteLine("Informe a palavra:");
            string palavra = Console.ReadLine();

            char[] letras = palavra.ToCharArray();
            Array.Reverse(letras);
            string invertida = new string(letras);

            if (invertida == palavra)
            {
                Console.WriteLine(palavra + " é palíndromo");
            }
            else
            {
                Console.WriteLine(palavra + " não é palíndromo");
            }
        }
    }
}
