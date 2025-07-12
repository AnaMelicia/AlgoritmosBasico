using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.Entidades
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }
        public Cachorro()
        {
        }
        public override void EmitirSom()
        {
            Console.WriteLine("O " + Nome + " faz auau!" );
        }
    }
}
