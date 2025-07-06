using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.Entidades;

namespace teste
{
    public static class Exercicio18
    {
        public static void Executar()
        {
            var playlist= new Playlist("This is Matue");
            var musica1 = new Musica("Cogulandia", "Trap", 2);
            playlist.AdicionarMusica(musica1);
            var musica2 = new Musica("Maquina do Tempo", "Trap", 3);
            playlist.AdicionarMusica(musica2);

            playlist.ListarMusicas();
            playlist.CalcularDuracao();



        }
    }
}
