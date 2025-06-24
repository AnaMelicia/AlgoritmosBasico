using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class Exercicio_3
    {
        public static void Executar()
        {

            const float notaDeAprovacao = 7;

            var notas = new float[3];

            for (int pergunta = 0; pergunta <= 2; pergunta++)
            {
                notas[pergunta] = PegarDadoFloat("Insira nota "+ (pergunta + 1) +"  do aluno:");
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
