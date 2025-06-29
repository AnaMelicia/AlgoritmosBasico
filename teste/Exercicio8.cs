using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class Exercicio_8
    {
        public static void Executar()
        {
            Dictionary<string, string> FeiticosHarryPotter = new Dictionary<string, string>();

            FeiticosHarryPotter.Add("Lumos", "Luz");
            FeiticosHarryPotter.Add("Alohomora", "Destrancar Porta");
            FeiticosHarryPotter.Add("OculosReparus", "Reparar Oculos");
            FeiticosHarryPotter.Remove("OculosReparus");

            Console.WriteLine("Digite o nome de um feitiço");
            var feitico = Console.ReadLine();

            if (FeiticosHarryPotter.ContainsKey(feitico))
            {
                Console.WriteLine(FeiticosHarryPotter[feitico]);
            }
            else
            {
                Console.WriteLine("O feitiço não foi aprendido em Hogwarts");
            }
        }
    }
}
