﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace teste.Entidades
{
    public class Feiticeiro
    {
        public Feiticeiro(string nome, string casa, int ano, string feiticoFavorito)
        {
            Nome = nome;
            Casa = casa;
            Ano = ano;
            FeiticoFavorito = feiticoFavorito;
        }
        public Feiticeiro()
        {
        }
        public string Nome { get; set; }
        public string Casa { get; set; }
        public int Ano { get; set; }
        public string FeiticoFavorito { get; set; }

        public void LancarFeitico()
        {

           Console.WriteLine(Nome + " lançou o feitiço " + FeiticoFavorito + "!");

        }       
    }
}
