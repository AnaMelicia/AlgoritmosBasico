using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Entidades
{
    public class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        {
        }

        public Gato()
        {
        }
        public override void EmitirSom()
        {
            Console.WriteLine("O/A " + Nome + " faz Miaaauuuu!" );
        }
    }
}
