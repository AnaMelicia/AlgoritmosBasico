using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using teste.OLD;
using teste.OLD.Entidades;

namespace teste.OLD
{
    public static class Exercicio17
    {
        public static void Executar()
        {

            var animal = new Gato();
            animal.Nome = "Doris";
           

            animal.EmitirSom();

            var animal2 = new Cachorro();
            animal2.Nome = "Chica";
          

            animal2.EmitirSom();

        }

    }
}
