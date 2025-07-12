using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace teste.Entidades
{
    public class Animal
    {
        public Animal(string nome)
        {
            Nome = nome;
        }

        public Animal()
        {
        }
        public string Nome { get; set; }
       
        public virtual void EmitirSom()
        {
          
        }

    }
}
