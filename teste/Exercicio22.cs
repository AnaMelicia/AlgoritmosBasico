using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace teste
{
    public static class Exercicio22
    {
        public static void Executar()
        {
            string opcao;
            List<Feiticeiro> feiticeiros = new List<Feiticeiro>();
            List<MembroBTS> MembrosBTS = new List<MembroBTS>();
            List<Gato> Gatos = new List<Gato>();
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Adicionar Feiiceiro");
                Console.WriteLine("2. Adicionar Membro do BTS");
                Console.WriteLine("3. Adicionar Gato");
                Console.WriteLine("4. Listar todos os cadastrados");
                Console.WriteLine("5. Sair");
                opcao = Console.ReadLine();

                if (opcao == "1")
                { 
                    Console.WriteLine("Nome do feiticeiro:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Casa do feiticeiro:");
                    string casa = Console.ReadLine();
                    Console.WriteLine("Ano do feiticeiro:");
                    int ano = int.Parse(Console.ReadLine());
                    Console.WriteLine("Feitiço favorito:");
                    string feiticofavorito = Console.ReadLine();

                    Feiticeiro novoFeiticeiro = new Feiticeiro(nome, casa, ano, feiticofavorito);

                    feiticeiros.Add(novoFeiticeiro);

                    Console.WriteLine("Feiticeiro Adicionado");
                   
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Nome do Membro do BTS:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Sua posição no grupo:");
                    string posicao = Console.ReadLine();

                   MembroBTS novomembro = new MembroBTS(nome, posicao);
 
                   MembrosBTS.Add(novomembro);

                   Console.WriteLine("Mebro do BTS Adicionado");
                   
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Nome do Gato:");
                    string nome = Console.ReadLine();

                    Gato novogato = new Gato(nome);

                    Gatos.Add(novogato);

                    Console.WriteLine("Gato Adicionado");
                    
                }
                else if (opcao =="4")
                {
                    Console.WriteLine("Lista de feiticeiros:");
                    foreach (Feiticeiro feiticeiro in feiticeiros)
                    {
                        Console.WriteLine(feiticeiro.Nome);
                    }
                    Console.WriteLine("Lista de membros do BTS:");
                    foreach (MembroBTS membro in MembrosBTS)
                    {
                        Console.WriteLine(membro.Nome);
                    }
                    Console.WriteLine("Lista de Gatos:");
                    foreach (Gato gato in Gatos)
                    {
                        Console.WriteLine(gato.Nome);
                    }
                }

            }
            while (opcao != "5");
        }
    }
}

