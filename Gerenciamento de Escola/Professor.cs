using System;


namespace Gerenciamento_de_Escola
{
    public class Professor : Pessoa
    {
        public List<Disciplina> listaDisciplinas;

    public Professor(List<Disciplina> listaDisciplinas, string nome, int idade) : base (nome, idade)
        {
            this.listaDisciplinas = listaDisciplinas ?? new List<Disciplina>();
        }
        /// <summary>
        /// Método responsável por adicionar/relacionar uma disciplina ao professor.
        /// </summary>
        /// <param name="disciplina"></param>
        public void AtribuirDisciplina(Disciplina disciplina)
        {
            if (disciplina != null && !listaDisciplinas.Contains(disciplina))
            {
                listaDisciplinas.Add(disciplina);
            }
        }

        public override void Exibir()
        {
            Console.WriteLine($"O professor {this.nome} leciona as seguintes disciplinas:");
            foreach (var disciplinas in this.listaDisciplinas)
            {
                Console.WriteLine(disciplinas.nomeDisciplina);
            }
        }
    }
}
