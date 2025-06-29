using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace teste
{
    public static class Exercicio_11
    {
        //Matuê onde ele precisa repetir os beats 100 vezes.Conte de 1 a 100 no console com frases como “Beat número 1 tocando…”
        public static void Executar()
        {
            for (int beats = 0; beats <= 100; beats++)
            {

                Console.WriteLine("Beat número " + beats + " do Matue tocando…");
            }

        }
    }
}
