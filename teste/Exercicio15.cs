using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.Entidades;

namespace teste
{
    public class Exercicio15
    {
        public static void Executar()
        {

            var vampiro = new Vampiro();
            vampiro.SetIdade(80);
            vampiro.SetHabilidadeEspecial("Telecinese");
            vampiro.SetNome("joao");

            vampiro.BrilharNoSol();

            var vampiro2 = new Vampiro("Ana",30,"Amard+");

            vampiro2.BrilharNoSol();

        }
    }
}
