using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Entidades
{
    public class Playlist 
    {
        public string Nome {  get; set; }
        public List<Musica> Musicas {  get; set; }
        public Playlist(string nome) 
        {
            Musicas = new List<Musica>();
            Nome = nome;
        }

        public void AdicionarMusica(Musica musica)
        {
            Musicas.Add(musica);
        }
        public void ListarMusicas()
        {
            foreach (var musica in Musicas)
            {
                Console.WriteLine("Estas são as músicas do Matue: " + musica.Titulo);
            }
        }
        public void CalcularDuracao()
        {
            foreach (var musica in Musicas)
            {
                Console.WriteLine("Este é o tempo de cada músuca do Matue: " + musica.Duracao);
            }
        }
               
    }
}
