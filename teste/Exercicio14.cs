using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.Entidades;

namespace teste
{
    public static class Exercicio14 
    {
        public static void Executar() 
        {
            var feiticeiro = new Feiticeiro();
            feiticeiro.Nome = "joao";
            feiticeiro.Casa = "Corvinal";
            feiticeiro.Ano = 4;
            feiticeiro.FeiticoFavorito = "Crucios";

            var feiticeiro2 = new Feiticeiro();
            feiticeiro2.Nome = "Ana";
            feiticeiro2.Casa = "LufaLufa";
            feiticeiro2.Ano = 2;
            feiticeiro2.FeiticoFavorito = "Accio";

            feiticeiro.LancarFeitico();
            feiticeiro2.LancarFeitico();

           
        }
    }
}
