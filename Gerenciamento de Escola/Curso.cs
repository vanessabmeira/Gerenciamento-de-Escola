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
        public string alunosMatriculados;
        public string disciplina;

        public Curso (string nomeCurso, int codigoCurso, string alunosMatriculados, string disciplina)
        {
            this.nomeCurso = nomeCurso;
            this.codigoCurso = codigoCurso;
            this.alunosMatriculados = alunosMatriculados;
            this.disciplina = disciplina;
        }
        public void MatricularAluno()
        {
        }
    }
}
