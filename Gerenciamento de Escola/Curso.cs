using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{
    public class Curso
    {
        public string nomeCurso;
        public int codigoCurso;
        public List<Aluno> alunosMatriculados;
        public List<Disciplina> disciplina;

        public Curso (string nomeCurso, int codigoCurso)
        {
            this.nomeCurso = nomeCurso;
            this.codigoCurso = codigoCurso;
            this.alunosMatriculados = new List<Aluno>();
            this.disciplina = new List<Disciplina>();
        }
        public void MatricularAluno(Aluno aluno)
        {
            if (aluno != null && !alunosMatriculados.Contains(aluno))
            {
                alunosMatriculados.Add(aluno);
                aluno.MatricularEmCurso(this);
            }
        }
    }
}
