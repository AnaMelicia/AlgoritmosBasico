using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{

    public  class Exercicio_1
    {

        public  void Executar()
        {

            const float notaDeAprovacao = 7;
           
            var nota = 0.0;
            var nota2 = 0.0;
            var nota3 = 0.0;

            for (int pergunta = 0; pergunta <= 2; pergunta++)
            {
                if (pergunta == 0)
                {
                    nota = PegarDadoFloat("Insira a primeira nota do aluno:");
                }
                else if (pergunta == 1)
                {
                    nota2 = PegarDadoFloat("Insira a segunda nota do aluno:");
                }
                else
                {
                    nota3 = PegarDadoFloat("Insira a terceira nota do aluno:");
                }

            }

            var media = (nota + nota2 + nota3) / 3;


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
