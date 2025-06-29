using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class Exercicio_9
    {
        public static void Executar()
        {
            //Peça que o usuário digite a idade dele. Se ele digitar algo que não seja número, trate o erro e exiba uma mensagem engraçada tipo:
            //"Edward Cullen diz: ‘isso não é uma idade válida, humano!’"

            try 
            {
                Console.WriteLine("Qual sua idade?");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine($"Os volturis são mais velhos que isso! ");
                
            }
            catch (Exception e)
            { 
                Console.WriteLine("Edward Cullen diz: ‘isso não é uma idade válida, humano!’");
                Console.WriteLine("Detalhe: " + e.Message);
            }   
        }
    }
}
