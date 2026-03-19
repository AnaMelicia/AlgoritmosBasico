using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.POO.Entidades
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade {  get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            VerificaIdade();
        }


        public void VerificaIdade()
        {
            if (Idade < 0)
            {
                Console.WriteLine("A idade não pode ser menor que zero.");
                Idade = 0;
                return;
            }
        }
        public void ExibirDados()
        {  
                Console.WriteLine($"Nome: {Nome}");
   
                Console.WriteLine($"Idade: {Idade}");    
        }

    }
}
