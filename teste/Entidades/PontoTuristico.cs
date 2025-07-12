using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Entidades
{
    public class PontoTuristico
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Localizacao { get; set; }
        public string Descricao { get; set; }

        public void ExibirInfo()
        {
            Console.WriteLine( "Ponto Turistico: " + Nome );
            Console.WriteLine("Este ponto turistico é uma ótima opção para quem gosta de passeios tipo: " + Tipo );
            Console.WriteLine("Locanizado em: " + Localizacao );
            Console.WriteLine( "Veja uma breve descrição sobre o ponto turistico em questão: " + Descricao );
         }
    }
}
