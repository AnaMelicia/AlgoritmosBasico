using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Entidades
{
    public class Vampiro
    {
        public Vampiro(string nome, int idade, string habilidadeEspecial)
        {
            Nome = nome;
            Idade = idade;
            HabilidadeEspecial = habilidadeEspecial;
        }

        public Vampiro()
        {
        }

        public string Nome { get;  private set; }
        public int Idade { get; private set; }
        public string HabilidadeEspecial { get; private set; }

        public void SetNome(string nome) 
        {
            
            Nome = nome;
            
        }
        public void SetIdade(int idade)
        {
            
            Idade = idade;

        }
        public void SetHabilidadeEspecial(string habilidadeespecial)
        {
            
          HabilidadeEspecial = habilidadeespecial;

        }

        public void BrilharNoSol()
        {

            Console.WriteLine("Edward diz: Essa é a pele de um caçador " + Nome);
            Console.WriteLine("Jesme diz: " + Idade + " Eu sou " + (Idade + 100) + " anos mais velho que você!");
            Console.WriteLine("Carlisle diz: Sua Habilidade de " + HabilidadeEspecial + " Vai ser muito útil contra os volturi");
        }
    }
}
