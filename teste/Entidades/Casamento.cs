using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Entidades
{
    public class Casamento
    {
        public Casamento(string noiva, string noivo, string data, string local)
        {
            Noiva = noiva;
            Noivo = noivo;
            Data = data;
            Local = local;
        }
        public Casamento()
        {
        }

        public string Noiva { get;  private set; }
        public string Noivo { get; private set; }
        public string Data { get; private set; }
        public string Local { get; private set; }

        public void SetNoiva(string noiva)
        {

            Noiva = noiva;

        }
        public void SetNoivo(string noivo)
        {

            Noivo = noivo;

        }
        public void SetData(string data)
        {

            Data = data;

        }
        public void SetLocal(string local)
        {

            Local = local;

        }

        public void GerarConvite()
        {
            Console.WriteLine(Noiva + " e " + Noivo + " convidam você para seu casamento em " + Local + ", no dia " + Data +"!");
        }

    }
}
