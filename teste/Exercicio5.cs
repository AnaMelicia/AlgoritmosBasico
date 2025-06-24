using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class Exercicio_5
    {
        public static void Executar()
        {

            const float notaDeAprovacao = 7;

            List<float> notas = new List<float>();

            for (int pergunta = 0; pergunta <= 2; pergunta++)
            {
                notas.Add(PegarDadoFloat("Insira nota " + (pergunta + 1) + "  do aluno:"));
            }

            var media = (notas[0] + notas[1] + notas[2]) / 3;


            if (media >= notaDeAprovacao)
            {
                Console.WriteLine("A media do aluno é maior ou igual que a nota necessária!");
            }
            else
            {
                Console.WriteLine("A media do aluno é menor que a nota necessária");
            }
        }

        private static float PegarDadoFloat(string pergunta)
        {
            Console.WriteLine(pergunta);
            var nota = float.Parse(Console.ReadLine());
            return nota;
        }
    }
}
