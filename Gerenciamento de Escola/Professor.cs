﻿using System;


namespace Gerenciamento_de_Escola
{
    public class Professor : Pessoa
    {
        public List<Disciplina> listaDisciplinas;

    public Professor(List<Disciplina> listaDisciplinas, string nome, int idade) : base (nome, idade)
        {
            this.listaDisciplinas = listaDisciplinas;
        }
    }
}