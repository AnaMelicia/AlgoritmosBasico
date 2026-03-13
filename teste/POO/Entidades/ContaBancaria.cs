using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace teste.POO.Entidades
{
    public class ContaBancaria
    {
        public float Saldo { get; private set; }
        public string Nome { get; set; }
        public string CPF { private get; set; }
        public string CNPJ { get; set; }

        public ContaBancaria(string nome, string cpf)
        {
            Saldo = 0;
            Nome = nome;
            CPF = cpf;
            ValidarCPF();
        }

        private void ValidarCPF()
        {
            if (CPF.Length != 14 || CPF[3] != '.' || CPF[7] != '.' || CPF[11] != '-')
            {
                throw new ArgumentException("CPF inválido. O formato deve ser xxx.xxx.xxx-xx");
            }
        }

        public void Depositar(float valor)
        {
            Saldo += valor;
        }

        public string GetCPF()
        {
           return CPF;
        }

        public void Sacar(float valor) 
        {
            if (Saldo <= 0)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                return;
            }

            if(valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
                return;
            }
            Saldo -= valor;
        }

        public void ExibirSaldo() 
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"CNPJ: {CNPJ}");
            Console.WriteLine($"Saldo: {Saldo}");
        }

        public void Trasnferir(ContaBancaria destino, float valor)
        {
            Sacar(valor);
            destino.Depositar(valor);

        }
    }
}
