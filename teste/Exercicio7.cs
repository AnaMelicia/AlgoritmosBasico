using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace teste
{
    public static class Exercicio_7
    {

        public static void Executar()
        {
            Console.WriteLine("Qual a data de início do namoro?");
            DateTime dataNamoro = DateTime.Parse("2022-09-26");
            Console.WriteLine(dataNamoro);

            Console.WriteLine("Há quantos dias o casal está junto?");
            DateTime dataHoje = DateTime.Now;
            DateTime dataHojeeee = DateTime.Parse("2025-07-27");

            
            TimeSpan tempoNamoro = dataHoje - dataNamoro;
            Console.WriteLine(((int)tempoNamoro.TotalDays));

            CalcularProximoAniversarioDeNamoro(dataHojeeee, dataNamoro);
            CalcularQuantosDiasFaltamNiver(dataNamoro, dataHoje );

        }
        private static void CalcularQuantosDiasFaltamNiver(DateTime dataNamoro, DateTime dataHoje)
        {
            Console.WriteLine("Qual a data do seu nascimento?");
            DateTime dataNascimento = DateTime.Parse("2003-10-16");
            Console.WriteLine("Você nasceu no dia " + dataNascimento.DayOfWeek);

            var proxAnoNiver = new DateTime(dataHoje.Year, dataNascimento.Month, dataNascimento.Day);
            if (proxAnoNiver < dataHoje)
            {
                proxAnoNiver = proxAnoNiver.AddYears(1);
            }

            var diasFaltantes = proxAnoNiver - dataHoje;

            Console.WriteLine($"Faltam {diasFaltantes.Days} dias para o seu aniversário.");
        }

        private static void CalcularProximoAniversarioDeNamoro(DateTime dataHojeeee, DateTime dataNamoro)
        {
            if (dataNamoro.Month == dataHojeeee.Month)
            {
                if (dataNamoro.Day < dataHojeeee.Day)
                {
                    Console.WriteLine("Próximo aniversário de namoro é no mês " + dataNamoro.Month + " de " + (dataHojeeee.Year + 1));

                }
                else if (dataNamoro.Day == dataHojeeee.Day)
                {
                    Console.WriteLine("O aniversário é hoje, próximo aniversário de namoro é no mês " + dataNamoro.Month + " de " + (dataHojeeee.Year + 1));
                }
                else
                {
                    Console.WriteLine("Próximo aniversário de namoro é no mês " + dataNamoro.Month + " de " + dataHojeeee.Year);
                }
            }
            else if (dataHojeeee.Month < dataNamoro.Month)
            {
                Console.WriteLine("Próximo aniversário de namoro é no mês " + dataNamoro.Month + " de " + dataHojeeee.Year);
            }
            else
            {
                Console.WriteLine("O aniversário é hoje, próximo aniversário de namoro é no mês " + dataNamoro.Month + " de " + (dataHojeeee.Year + 1));
            }
        }
    }
}
