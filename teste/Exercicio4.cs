using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class Exercicio_4
    {
        public static void Executar()
        {
            var nome = "Ana Melicia ";
            var sobrenome = "David De Lima";
            Console.WriteLine(nome + sobrenome + " é casada com joão Vitor");
            Console.WriteLine($"{nome}{sobrenome} é casada com joão vitor");
            Console.WriteLine(string.Concat(nome, sobrenome + " é casada com joão vitor"));
        }
    }
}
