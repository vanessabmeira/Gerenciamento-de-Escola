using System;


namespace Gerenciamento_de_Escola
{
    public class Aluno : Pessoa
    {
        private int matricula;
        private List<Curso> listaDeCursos;

        public Aluno(int matricula, string nome, int idade): base (nome, idade)
        {
            this.matricula = matricula;
            this.listaDeCursos = new List<Curso>();
        }
        /// <summary>
        /// Método responsável por adicionar o aluno na lista de um curso.
        /// </summary>
        /// <param name="curso"></param>
        internal void MatricularEmCurso(Curso curso)
        {
            if (curso != null && !listaDeCursos.Contains(curso))
            {
                listaDeCursos.Add(curso);
                curso.MatricularAluno(this);
            }
        }

        public override void Exibir()
        {
            Console.WriteLine($"Aluno(a) {this.nome} está matriculado(a) nos cursos:");
            foreach (var curso in this.listaDeCursos)
            {
                Console.WriteLine(curso.nomeCurso);
            }
        }

    }
}
