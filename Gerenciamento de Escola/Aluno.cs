using System;


namespace Gerenciamento_de_Escola
{
    public class Aluno : Pessoa
    {
        public int matricula;
        public List<Curso> listaDeCursos;

        public Aluno(int matricula, List<Curso> listaDeCursos, string nome, int idade): base (nome, idade)
        {
            this.matricula = matricula;
            this.listaDeCursos = listaDeCursos;
        }



    }
}
