using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Entidades
{
    public class MembroBTS
    {
        public MembroBTS(string nome, string posicao)
        {
            Nome = nome;
            Posicao = posicao;
        }
        public MembroBTS()
        {
        }
        public string Nome {  get; private set; }
        public string Posicao { get; private set; }

         public void SetNome(string nome)
        {

            Nome = nome;

        }
        public void SetPosicao(string posicao)
        {

            Posicao = posicao;

        }

        public void ListarMembros()
        {
            Console.WriteLine(Nome + " é o " + Posicao + " do grupo BTS.");
        }
    }
}
