using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class Exercicio_13
    {
        public static void Executar()
        {
            string opcao;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. subtração");
                Console.WriteLine("2. Adição");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");
                opcao = Console.ReadLine();


                if (opcao == "1")
                {
                    var numero1 = PegarDadoFloat("Digite o primeiro número:");
                    var numero2 = PegarDadoFloat("Digite o segundo número:");


                    float total = numero1 - numero2;

                        Console.WriteLine("Resultado: " + total);
                        
                }
                else if (opcao == "2")
                {

                    var numero1 = PegarDadoFloat("Digite o primeiro número:");
                    var numero2 = PegarDadoFloat("Digite o segundo número:");

                    float total = numero1 + numero2;

                        Console.WriteLine("Resultado: " + total);
                        
                    
                }
                else if (opcao == "3")
                {

                    var numero1 = PegarDadoFloat("Digite o primeiro número:");
                    var numero2 = PegarDadoFloat("Digite o segundo número:");

                    float total = numero1 * numero2;

                        Console.WriteLine("Resultado: " + total);
                        
                    
                }
                else if (opcao == "4")
                {

                    var numero1 = PegarDadoFloat("Digite o primeiro número:");
                    var numero2 = PegarDadoFloat("Digite o segundo número:"); 

                        float total = numero1 % numero2;

                        Console.WriteLine("Resultado: " + total);
                        
                    
                }
            } 
            while (opcao != "5");


        }
        private static float PegarDadoFloat(string pergunta)
        {
            Console.WriteLine(pergunta);
            float numero = float.Parse(Console.ReadLine());
            return numero;
        }
    }
}
