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
            DateTime dataHojeeee = DateTime.Parse("2025-09-25");
            
            TimeSpan tempoNamoro = dataHoje - dataNamoro;

            Console.WriteLine(((int)tempoNamoro.TotalDays));

            //Preciso da data de hoje e preciso do mes e dia do namoro e comparando o mes e ano

            if (dataNamoro.Month <= dataHojeeee.Month)
            {
                if (dataNamoro.Day >= dataHojeeee.Day)
                {
                    Console.WriteLine("Próximo aniversário de namoro é no mês " + dataNamoro.Month + " de " + (dataHojeeee.Year + 1));

                }
            }
            else
            {
                Console.WriteLine("Próximo aniversário de namoro é no mês " + dataNamoro.Month + " de " + dataHojeeee.Year);
            }

        }
    }
}
