using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Entidades
{
    public class Musica
    {
        public Musica(string titulo, string estiloMusical, int duracao)
        {
            Titulo = titulo;
            EstiloMusical = estiloMusical;
            Duracao = duracao;
        }
        public Musica()
        {
        }

        public string Titulo { get; private set; }
        public string EstiloMusical { get; private set; }
        public int Duracao { get; private set; }

        public void setTitulo(string titulo)
        {

            Titulo = titulo;

        }
        public void setEstiloMusical(string estiloMusical)
        {

            EstiloMusical = estiloMusical;

        }
        public void setDuracao(int duracao)
        {

            Duracao = duracao;

        }

    }
}
