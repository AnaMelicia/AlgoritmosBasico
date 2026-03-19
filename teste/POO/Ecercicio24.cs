using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.POO
{
    public class Ecercicio24
    {
        public static void Executar()
        {
            var pessoa = new Entidades.Pessoa("Maria", 30);
         

            var pessoa2 = new Entidades.Pessoa("João",-5);


            pessoa.ExibirDados();
            pessoa2.ExibirDados();
        }
    }
}
