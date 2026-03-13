using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.POO
{
    public class Exercicio23
    {
        public static void Executar()
        {
            var conta = new Entidades.ContaBancaria("Ana", "128.141.599-50"); //instanciando a classe ContaBancaria
            //conta.Nome = "Ana"; //setando o nome da conta
            //conta.CPF = "128.141.599-50";
            conta.Depositar(1000);
            conta.Sacar(10000);
            
           

            var conta2 = new Entidades.ContaBancaria("João", "128.141.599-50");
             conta2.Depositar(500);
             


            conta.Trasnferir(conta2, 500);
            conta.ExibirSaldo();
            conta2.ExibirSaldo();
        }
    }
}
