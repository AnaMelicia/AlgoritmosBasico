using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class Exercicio_2
    {
        public static void Executar()
        {
            var listaDeMercado = new string[3];
            listaDeMercado = ["escova de dente", "Shampoo", "pizza perdigao"];
            listaDeMercado[0] = "Bucha";
            Console.WriteLine(listaDeMercado[0]);

            List<float> notas = new List<float>();
            notas.Add(4);
            notas.Add(5);
            notas.Add(6);
            Console.WriteLine(notas[0]);
        }
    }
}
