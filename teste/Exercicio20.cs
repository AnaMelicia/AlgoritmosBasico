using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste.Entidades;

namespace teste
{
    public  class Exercicio20
    {
        public static void Executar()
        {
            var pontoturistco = new PontoTuristico();
            pontoturistco.Nome = "jardim Botanico";
            pontoturistco.Tipo = "Passeio Leve";
            pontoturistco.Localizacao = "Itacorumbi - Florianópolis";
            pontoturistco.Descricao = "oferece espaços como pista de caminhada, academia ao ar livre e eventos culturais.";

            pontoturistco.ExibirInfo();

            var pontoturistco2 = new PontoTuristico();
            pontoturistco2.Nome = "Ponte Hercílio Luz";
            pontoturistco2.Tipo = "Passeio Leve";
            pontoturistco2.Localizacao = "Centro - Florianópolis ";
            pontoturistco2.Descricao = "cartão postal da cidade, com uma vista deslumbrante do pôr do sol.";

            pontoturistco2.ExibirInfo();

            var pontoturistco3 = new PontoTuristico();
            pontoturistco3.Nome = "Voo de Parapente";
            pontoturistco3.Tipo = "Radical";
            pontoturistco3.Localizacao = "Lagoa da Conceição - Florianópolis ";
            pontoturistco3.Descricao = "saltando da Rampa da Lagoa da Conceição, poderá ter uma visão panorâmica da ilha.";

            pontoturistco3.ExibirInfo();
        }
    }
}
