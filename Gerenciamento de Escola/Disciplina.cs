﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{
    public class Disciplina
    {
        public string nomeDisciplina;
        public double cargaHoraria;
        public string ementa;

        public Disciplina (string nomeDisciplina, double cargaHoraria, string ementa)
        {
            this.nomeDisciplina = nomeDisciplina;
            this.cargaHoraria = cargaHoraria;
            this.ementa = ementa;
        }
    }
}
