using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Escola
{
    public class Curso
    {
        internal string nomeCurso;
        private int codigoCurso;
        private List<Aluno> alunosMatriculados;
        private List<Disciplina> listaDisciplinas;

        public Curso (string nomeCurso, int codigoCurso)
        {
            this.nomeCurso = nomeCurso;
            this.codigoCurso = codigoCurso;
            this.alunosMatriculados = new List<Aluno>();
            this.listaDisciplinas = new List<Disciplina>();
        }
        /// <summary>
        /// Responsável por adicionar/relacionar o aluno em um curso.
        /// </summary>
        /// <param name="aluno"></param>
        public void MatricularAluno(Aluno aluno)
        {
            if (aluno != null && !alunosMatriculados.Contains(aluno))
            {
                alunosMatriculados.Add(aluno);
                aluno.MatricularEmCurso(this);
            }
        }

        /// <summary>
        /// Responsável por adicionar a disciplina na lista de disciplinas
        /// </summary>
        /// <param name="disciplina"></param>
        public void AdicionarDisciplina(Disciplina disciplina)
        {
            if (disciplina != null && !listaDisciplinas.Contains(disciplina))
            {
                listaDisciplinas.Add(disciplina);
            }
        }

        /// <summary>
        /// Método responsável de mostrar todos os alunos já matriculados no curso.
        /// </summary>
        public void ExibirAlunosMatriculados()
        {
            Console.WriteLine($"O curso {this.nomeCurso} possui os seguintes alunos matriculados:");
            foreach (var aluno in this.alunosMatriculados)
            {
                Console.WriteLine(aluno.nome);
            }
        }
        /// <summary>
        /// Método responsável por exibir todas as disciplinas do curso.
        /// </summary>
        public void ExibirDisciplinas()
        {
            Console.WriteLine($"O curso {this.nomeCurso} possui as seguintes disciplinas:");
            foreach (var disciplinas in this.listaDisciplinas)
            {
                Console.WriteLine(disciplinas.nomeDisciplina);
            }
        }
    }
}
