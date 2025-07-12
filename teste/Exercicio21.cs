using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.Entidades;

namespace teste
{
    public static class Exercicio21
    {
        public static void Executar()
        {
            var Ana= new Casamento("Ana","João", "2022-09-26", "Jardim Botanico");
            Ana.GerarConvite();

            var João = new Casamento("Ana", "João", "2022-09-26" , "Jardim Botanico");


            List<Casamento> pessoas = new List<Casamento>();
            pessoas.Add(Ana);
            pessoas.Add(João);
        }
    }
}
