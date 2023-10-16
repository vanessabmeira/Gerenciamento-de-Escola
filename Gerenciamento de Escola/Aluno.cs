using System;


namespace Gerenciamento_de_Escola
{
    public class Aluno : Pessoa
    {
        public int matricula;
        public List<Curso> listaDeCursos;

        public Aluno(int matricula, string nome, int idade): base (nome, idade)
        {
            this.matricula = matricula;
            this.listaDeCursos = new List<Curso>();
        }

        public void MatricularEmCurso(Curso curso)
        {
            if (curso != null && !listaDeCursos.Contains(curso))
            {
                listaDeCursos.Add(curso);
                curso.MatricularAluno(this);
            }
        }

        public List<Curso> ExibirCursosMatriculados()
        {
            return listaDeCursos;
        }

    }
}
