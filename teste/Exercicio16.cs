using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.Entidades;

namespace teste
{
    public class Exercicio16
    {
        public static void Executar()
        {
            var jungkook = new MembroBTS("Jungkook", "Vocal");
            jungkook.ListarMembros();
            var Jimin = new MembroBTS("Jimin", "Vocal");
            Jimin.ListarMembros();
            var V = new MembroBTS("V", "Vocal");
            V.ListarMembros();
            var Hope = new MembroBTS("Hope", "rapper");
            Hope.ListarMembros();
            var Jin = new MembroBTS("Jin", "rapper");
            Jin.ListarMembros();
            var Suga = new MembroBTS("Suga", "rapper");
            Suga.ListarMembros();
            var RM = new MembroBTS("RM", "visual");
            RM.ListarMembros();


            List<MembroBTS> membrosbts  = new List<MembroBTS>();

            membrosbts.Add(jungkook);
            membrosbts.Add(Jimin);
            membrosbts.Add(V);
            membrosbts.Add(Hope);
            membrosbts.Add(Jin);
            membrosbts.Add(Suga);
            membrosbts.Add(RM);
        }

    }
}
